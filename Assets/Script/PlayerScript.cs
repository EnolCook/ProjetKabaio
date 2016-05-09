using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent (typeof(CharacterController))]
public class PlayerScript : MonoBehaviour
{
	[SerializeField]
	private float Speed = 5;


	private CharacterController Controller;
	private Vector3 Right;
	private Vector3 Left;
	private Vector3 Down;

	private HandManager HandMana;

	public int PlayerID;
	private Player LocalPlayer;

	public bool LocalCanTake = false;
	public GameObject LightToTake;

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

		LocalPlayer.AddInputEventDelegate (Jump, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Jump");
		LocalPlayer.AddInputEventDelegate (MoveRight, UpdateLoopType.Update, InputActionEventType.ButtonPressed, "Right");
		LocalPlayer.AddInputEventDelegate (MoveLeft, UpdateLoopType.Update, InputActionEventType.ButtonPressed, "Left");
		LocalPlayer.AddInputEventDelegate (TakeObject, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Take");
	}

	void Update ()
	{
		GroundCheck ();
	}

	void TakeObject (InputActionEventData data)
	{
		if (LocalCanTake) {
			if (HandMana.InHand != HandManager.Hand.Light) {
				HandMana.TakeLight (LightToTake);
			}
		}
	}


	void MoveRight (InputActionEventData data)
	{
		Controller.SimpleMove (Right * Speed);
	}

	void MoveLeft (InputActionEventData data)
	{
		Controller.SimpleMove (Left * Speed);
	}

	void MoveDown ()
	{
		Controller.SimpleMove (Down * Speed * 0.5f);
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
		if (!Controller.isGrounded) {
			MoveDown ();
		}
	}

	void Jump (InputActionEventData data)
	{
		if (Controller.isGrounded) {
			Controller.Move (Vector3.up * 50 * (Speed / 10) * Time.deltaTime);
		}
	}

	void OnCollisionEnter (Collision thing)
	{
		Debug.Log (thing.gameObject.name);
	}
}
