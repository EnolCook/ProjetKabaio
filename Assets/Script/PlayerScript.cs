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

	void Start ()
	{
		Controller = GetComponent<CharacterController> ();
		Right = transform.TransformDirection (Vector3.right);
		Left = transform.TransformDirection (Vector3.left);
		Down = transform.TransformDirection (Vector3.down) * 10;
		HandMana = GetComponentInChildren<HandManager> ();

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
		GroundCheck ();
		Move ();
		UpdateHandPosition ();
	}

	void UpdateHandPosition ()
	{
		float LookX = LocalPlayer.GetAxis ("LookX");
		float LookY = LocalPlayer.GetAxis ("LookY");
		HandMana.InputWork (LookX, LookY);
	}

	void Action (InputActionEventData data)
	{
		HandMana.HandAction ();
	}

	void TakeObject (InputActionEventData data)
	{
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

	void StopRight (InputActionEventData data)
	{
		
		vel = Vector3.zero;
	}

	void StopLeft (InputActionEventData data)
	{

		vel = Vector3.zero;
	}

	void MoveRight (InputActionEventData data)
	{
		vel = (Right * Speed);
	}

	void MoveLeft (InputActionEventData data)
	{
		vel = (Left * Speed);
	}

	void Move ()
	{
		

		vel.y = vSpeed;
		if (!Controller.isGrounded) {
			vSpeed -= Gravity * Time.deltaTime;
		}

		vel -= Vector3.zero * 100;
		Controller.Move (vel * Speed * Time.deltaTime);
	
	}

	void GroundCheck ()
	{
		//Could replace isGrounded by a Raycast to have more precision. TODO if time and usage.
		RaycastHit Hit;
		if (Physics.Raycast (transform.position, Down, out Hit)) {
			if (Hit.distance > 1.1f) {
				OnGround = false;
			} else {
				OnGround = true;
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
		if (OnGround) {
			Jumping = true;
			vSpeed = JumpPower;
		}
	}

	void OnCollisionEnter (Collision thing)
	{
		if (thing.gameObject.CompareTag ("Ennemie")) {
			Debug.Log ("YOU DED");
		}
	}
}
