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

	void Start ()
	{
		Controller = GetComponent<CharacterController> ();
		Right = transform.TransformDirection (Vector3.right);
		Left = transform.TransformDirection (Vector3.left);
		Down = transform.TransformDirection (Vector3.down) * 10000000;
		HandMana = GetComponentInChildren<HandManager> ();
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
	}

	void Update ()
	{
		GroundCheck ();
		Move ();
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
		vSpeed -= 9.8f * Time.deltaTime;
		vel -= Vector3.zero * 100;
		Controller.Move (vel * Speed * Time.deltaTime);
		Debug.Log (vSpeed);
	
	}

	void GroundCheck ()
	{
		//Could replace isGrounded by a Raycast to have more precision. TODO if time and usage.
		/*RaycastHit Hit;
		if (Physics.Raycast (transform.position, Down, out Hit)) {
			if (Hit.distance > 2) {
				//Debug.Log ("Falling");
				MoveDown ();
			}
		}*/

		if (Controller.isGrounded) {
			vSpeed = 0;
		}
	}

	void Jump (InputActionEventData data)
	{
		if (Controller.isGrounded) {
			/*Controller.Move (Vector3.up * JumHigh * Speed * Time.deltaTime);*/
			vSpeed = JumpPower;
		}
	}

	void OnCollisionEnter (Collision thing)
	{
		Debug.Log (thing.gameObject.name);
	}
}
