using UnityEngine;
using System.Collections;
using Rewired;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NewMenuManager : MonoBehaviour
{
	public int PlayerID;
	private Player LocalPlayer;
	[SerializeField]
	private GameObject CurButton;
	private AxisEventData CurAxis;
	private GameObject myEventSystem;

	[SerializeField]
	private GameObject GO_HowToPlay;
	[SerializeField]
	private GameObject GO_Credits;
	[SerializeField]
	private GameObject GO_MainMenu;

	void Awake ()
	{
		LocalPlayer = ReInput.players.GetPlayer (PlayerID);
		LocalPlayer.AddInputEventDelegate (Up, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "UP");
		LocalPlayer.AddInputEventDelegate (Down, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "DOWN");
		LocalPlayer.AddInputEventDelegate (Select, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "SELECT");
	}

	void Start ()
	{
		CurAxis = new AxisEventData (EventSystem.current);
		myEventSystem = GameObject.Find ("EventSystem");
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (CurButton);
	}

	void Up (InputActionEventData data)
	{
		CurAxis.moveDir = MoveDirection.Up;
		ExecuteEvents.Execute (CurButton, CurAxis, ExecuteEvents.moveHandler);
	}

	void Down (InputActionEventData data)
	{
		CurAxis.moveDir = MoveDirection.Down;
		ExecuteEvents.Execute (CurButton, CurAxis, ExecuteEvents.moveHandler);
	}

	void Select (InputActionEventData data)
	{
		if (GO_HowToPlay.activeInHierarchy) {
			GO_MainMenu.SetActive (false);
			GO_Credits.SetActive (false);
			GO_HowToPlay.SetActive (false);
			SceneManager.LoadScene ("LD_Final");
		}
		if (GO_Credits.activeInHierarchy) {
			GO_MainMenu.SetActive (true);
			GO_Credits.SetActive (false);
			GO_HowToPlay.SetActive (false);
			myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (null);
		}

	}

	public void Play ()
	{
		GO_MainMenu.SetActive (false);
		GO_Credits.SetActive (false);
		GO_HowToPlay.SetActive (true);
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (null);
	}

	public void Credits ()
	{
		GO_MainMenu.SetActive (false);
		GO_Credits.SetActive (true);
		GO_HowToPlay.SetActive (false);
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (null);
	}

	public void QuitGame ()
	{
		Application.Quit ();
	}
}
