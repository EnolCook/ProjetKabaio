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
		Falling,
		Jumping
	}

	[SerializeField]
	private AnimState PlayerState;

	private float TempX = 1;

	void Start ()
	{
		Controller = GetComponent<CharacterController> ();
		Right = transform.TransformDirection (Vector3.right);
		Left = transform.TransformDirection (Vector3.left);
		Down = transform.TransformDirection (Vector3.down) * 10;
		HandMana = GetComponentInChildren<HandManager> ();
		PlayerAnimator = GetComponent<Animator> ();
		Physics.IgnoreLayerCollision (10, 11);
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
		if (CanMove) {
			GroundCheck ();
			Move ();
			UpdateHandPosition ();
			AnnimationManager ();
				
		
		}
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
	}

	void StopRight (InputActionEventData data)
	{
		
		vel = Vector3.zero;
		StartCoroutine ("IdleCheck");
		//PlayerState = AnimState.Idle;
	}

	void StopLeft (InputActionEventData data)
	{
		vel = Vector3.zero;
		StartCoroutine ("IdleCheck");
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
			if (!Controller.isGrounded) {
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
					PlayerState = AnimState.Falling;
				}

			} else {
				OnGround = true;
				if (PlayerState != AnimState.Left & PlayerState == AnimState.Falling || PlayerState != AnimState.Right & PlayerState == AnimState.Falling) {
					PlayerState = AnimState.Idle;
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
			Debug.Log ("YOU DED");
			GameManager.Instance.OnPlayerDied ();
			PlayerState = AnimState.Dead;
		}
	}

	IEnumerator IdleCheck ()
	{
		yield return new WaitForSeconds (0.1f);
		if (vel == Vector3.zero) {
			PlayerState = AnimState.Idle;
		}
	}


	void AnnimationManager ()
	{
		switch (PlayerState) {
		case AnimState.Dance:

			break;
		case AnimState.Dead:

			break;
		case AnimState.Falling:

			break;
		case AnimState.Idle:
			if (TempX > 0) {
				SetAnnimation ("b_Idle", false);
			} else if (TempX < 0) {
				SetAnnimation ("b_Idle", true);
			}
			break;
		case AnimState.Jumping:

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
		}
	}

	void SetAnnimation (string AnimState, bool Mirror)
	{
		foreach (string ST in AnimBools) {
			if (ST != AnimState) {
				PlayerAnimator.SetBool (ST, false);
			} else {
				if (!Mirror) {
					PlayerAnimator.SetBool (AnimState, true);
					this.gameObject.transform.localScale = new Vector3 (1f, 1f, 1f);
					Mirrored = false;
				} else {
					PlayerAnimator.SetBool (AnimState, true);
					Mirrored = true;
					this.gameObject.transform.localScale = new Vector3 (-1f, 1f, 1f);
				}

	
			}
		}
	}
}
