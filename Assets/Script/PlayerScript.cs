using UnityEngine;
using System.Collections;
using Rewired;
using DG.Tweening;

[RequireComponent (typeof(CharacterController))]
public class PlayerScript : MonoBehaviour
{

	[Header ("Jump")]
	[SerializeField]
	private float JumpPower = 2;
	[SerializeField]
	private float Gravity = 9.8f;



	private CharacterController Controller;
	private Vector3 Right;
	private Vector3 Left;
	private Vector3 Down;

	private HandManager HandMana;
	[Header ("Players Infos")]
	[SerializeField]
	private float Speed = 5;

	public int PlayerID;
	private Player LocalPlayer;

	public bool LocalCanTake = false;
	public GameObject LightToTake;

	private float vSpeed = 0;
	private Vector3 vel;
	private bool Jumping = false;
	private bool OnGround;
	private bool CanMove = true;
	public bool Mirrored = false;
	private Animator PlayerAnimator;

	[Header ("Animation")]
	[SerializeField]
	private string[] AnimBools;

	enum AnimState
	{
		Right,
		Left,
		Idle,
		Dead,
		Dance,
		Shooting,
		Reloading,
		PickingUp,
		Falling,
		JumEnd,
		Jumping
	}

	[SerializeField]
	private AnimState PlayerState;
	private bool Dead = false;
	private float TempX = 1;
	private AudioSource PlayerAudio;

	[Header ("Sounds")]
	[SerializeField]
	private AudioClip Walk;

	void Start ()
	{
		Controller = GetComponent<CharacterController> ();
		Right = transform.TransformDirection (Vector3.right);
		Left = transform.TransformDirection (Vector3.left);
		Down = transform.TransformDirection (Vector3.down) * 10;
		HandMana = GetComponentInChildren<HandManager> ();
		PlayerAudio = GetComponent<AudioSource> ();
		PlayerAnimator = GetComponent<Animator> ();
		Physics.IgnoreLayerCollision (10, 11);
		StartCoroutine ("CheckVelocity");
		StartCoroutine ("IdleCheck");
	}


	void Awake ()
	{
		LocalPlayer = ReInput.players.GetPlayer (PlayerID);
		DOTween.Init ();
		LocalPlayer.AddInputEventDelegate (Jump, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Jump");
		LocalPlayer.AddInputEventDelegate (MoveRight, UpdateLoopType.Update, InputActionEventType.ButtonPressed, "Right");
		LocalPlayer.AddInputEventDelegate (StopRight, UpdateLoopType.Update, InputActionEventType.ButtonJustReleased, "Right");
		LocalPlayer.AddInputEventDelegate (MoveLeft, UpdateLoopType.Update, InputActionEventType.ButtonPressed, "Left");
		LocalPlayer.AddInputEventDelegate (StopLeft, UpdateLoopType.Update, InputActionEventType.ButtonJustReleased, "Left");
		LocalPlayer.AddInputEventDelegate (TakeObject, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Take");
		LocalPlayer.AddInputEventDelegate (Action, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "ActionInput");
	}

	void Update ()
	{
		AnnimationManager ();
		if (CanMove) {
			GroundCheck ();
			Move ();
		}
	}

	void LateUpdate ()
	{
		UpdateHandPosition ();
	}

	void UpdateHandPosition ()
	{
		float LookX = LocalPlayer.GetAxis ("LookX");
		float LookY = LocalPlayer.GetAxis ("LookY");
		if (LookX != 0) {
			TempX = LookX;
		}
		HandMana.InputWork (LookX, LookY);
	}

	void Action (InputActionEventData data)
	{
		if (CanMove) {
			HandMana.HandAction ();
		}

	}

	void TakeObject (InputActionEventData data)
	{
		if (CanMove) {
			if (LocalCanTake) {
				if (HandMana.InHand != HandManager.Hand.Light) {
					HandMana.TakeLight (LightToTake);
					LocalCanTake = false;
					PlayerState = AnimState.PickingUp;
					StartCoroutine ("PickedUp");

				}
			} else {
				if (HandMana.InHand == HandManager.Hand.Light) {
					HandMana.DropLight ();
				}
			}
		}
	}

	public void ResetPlayer ()
	{
		if (HandMana.InHand == HandManager.Hand.Light) {
			GameManager.Instance.IHadLight = true;
		}
		HandMana.ResetHand ();
		vSpeed = 0;
		CanMove = false;
	}

	public void Continue ()
	{
		CanMove = true;
		Dead = false;
		PlayerState = AnimState.Idle;
	}

	void StopRight (InputActionEventData data)
	{
		
		vel = Vector3.zero;
		InstantIdleCheck ();
		//PlayerState = AnimState.Idle;
	}

	void StopLeft (InputActionEventData data)
	{
		vel = Vector3.zero;
		InstantIdleCheck ();
		//PlayerState = AnimState.Idle;
	}

	void MoveRight (InputActionEventData data)
	{
		vel = (Right * Speed);
		PlayerState = AnimState.Right;
	}

	void MoveLeft (InputActionEventData data)
	{
		vel = (Left * Speed);
		PlayerState = AnimState.Left;
	}

	void Move ()
	{
		if (PlayerState != AnimState.Dead) {
			vel.y = vSpeed;
			if (!OnGround) {
				vSpeed -= Gravity * Time.deltaTime;
			} 

			vel -= Vector3.zero * 100;
			Controller.Move (vel * Speed * Time.deltaTime);
		}
	}

	void GroundCheck ()
	{
		RaycastHit Hit;
		if (Physics.Raycast (transform.position, Down, out Hit)) {
			if (Hit.distance > 1.1f) {
				OnGround = false;
				if (vSpeed < 1) {
					if (Hit.distance < 2.4f && Hit.distance > 1.6f) {
						PlayerState = AnimState.JumEnd;
						//vel = Vector3.zero;
					} else {
						PlayerState = AnimState.Falling;
					}
				}

			} else {
				OnGround = true;
				if (PlayerState == AnimState.Falling || PlayerState == AnimState.Falling) {
					PlayerState = AnimState.Idle;
					vel = Vector3.zero;
					vSpeed = 0;
				}
			}
		}
		if (OnGround) {
			if (Jumping == false) {
				vSpeed = 0;
			}
		}
	}

	void Jump (InputActionEventData data)
	{
		if (CanMove) {
			if (OnGround) {
				Jumping = true;
				vSpeed = JumpPower;
				PlayerState = AnimState.Jumping;
			}
		}
	}

	void OnCollisionEnter (Collision thing)
	{
		if (thing.gameObject.CompareTag ("Ennemie")) {
			YouDie ();
		}
	}

	public void YouDie ()
	{
		//Debug.Log ("YOU DED");
		PlayerState = AnimState.Dead;
		Dead = true;
		GameManager.Instance.OnPlayerDied ();
	}

	IEnumerator IdleCheck ()
	{
		while (true) {
			yield return new WaitForSeconds (0.1f);
			if (vel == Vector3.zero) {
				PlayerState = AnimState.Idle;
			}
		}
	}

	void InstantIdleCheck ()
	{
		
		if (vel == Vector3.zero) {
			PlayerState = AnimState.Idle;
		}
	}

	IEnumerator CheckVelocity ()
	{
		while (true) {
			Vector3 TempVel;
			TempVel = vel;
			yield return new WaitForSeconds (0.4f);
			if (vel == TempVel) {
				vSpeed = 0;
			}
		}
	}


	IEnumerator PickedUp ()
	{
		yield return new WaitForSeconds (0.2f);
		PlayerState = AnimState.Idle;
	}


	void AnnimationManager ()
	{
		if (Dead) {
			if (TempX > 0) {
				SetAnnimation ("b_DeathFront", false);
			} else if (TempX < 0) {
				SetAnnimation ("b_DeathFront", true);
			}
		} else {
			switch (PlayerState) {
			case AnimState.Dance:

				break;
			case AnimState.Dead:
				if (TempX > 0) {
					SetAnnimation ("b_DeathFront", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_DeathFront", true);
				}
				break;
			case AnimState.Falling:
				if (TempX > 0) {
					SetAnnimation ("b_Fall", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_Fall", true);
				}
				break;
			case AnimState.Idle:
				if (TempX > 0) {
					SetAnnimation ("b_Idle", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_Idle", true);
				}
				break;
			case AnimState.Jumping:
				if (TempX > 0) {
					SetAnnimation ("b_JumpUp", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_JumpUp", true);
				}
				break;
			case AnimState.Left:
				if (TempX > 0) {
					SetAnnimation ("b_WalkBackward", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_Walkforward", true);
				}
				break;
			case AnimState.Reloading:

				break;
			case AnimState.Right:
				if (TempX > 0) {
					SetAnnimation ("b_Walkforward", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_WalkBackward", true);
				}
				break;
			case AnimState.Shooting:

				break;
			case AnimState.PickingUp:
				if (TempX > 0) {
					SetAnnimation ("b_Pickup", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_Pickup", true);
				}
				break;
			case AnimState.JumEnd:
				if (TempX > 0) {
					SetAnnimation ("b_JumpEnd", false);
				} else if (TempX < 0) {
					SetAnnimation ("b_JumpEnd", true);
				}
				break;
			}
		}

	}

	public void PlayAudio (AudioClip ToPlay, float Vol)
	{
		PlayerAudio.PlayOneShot (ToPlay, Vol);
	}

	public void StopAudio ()
	{
		PlayerAudio.Stop ();
	}

	void SetAnnimation (string AnimState, bool Mirror)
	{
		foreach (string ST in AnimBools) {
			if (ST != AnimState) {
				PlayerAnimator.SetBool (ST, false);
			} else {
				if (!Mirror) {
					PlayerAnimator.SetBool (AnimState, true);
					//this.gameObject.transform.localScale = new Vector3 (1f, 1f, 1f);
					this.gameObject.transform.rotation = (new Quaternion (0, 0, 0, 0));
					Mirrored = false;
				} else {
					PlayerAnimator.SetBool (AnimState, true);
					Mirrored = true;
					this.gameObject.transform.rotation = (new Quaternion (0, 180, 0, 0));
					//this.gameObject.transform.localScale = new Vector3 (-1f, 1f, 1f);
				}

	
			}
		}
	}
}
