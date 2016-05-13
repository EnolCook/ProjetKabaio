using UnityEngine;
using System.Collections;
using Rewired;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public int PlayerID;
	private Player LocalPlayer;

	[SerializeField]
	private GameObject GO_HowToPlay;
	[SerializeField]
	private GameObject GO_Credits;
	[SerializeField]
	private GameObject GO_MainMenu;
	[SerializeField]
	private GameObject GO_RewiredManager;

	enum MenuState
	{
		Main,
		Credit,
		HowTo,
		Starting
	}

	private MenuState MState;


	void Awake ()
	{
		LocalPlayer = ReInput.players.GetPlayer (PlayerID);
		LocalPlayer.AddInputEventDelegate (StartGame, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Start");
		LocalPlayer.AddInputEventDelegate (Credits, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Select");
		LocalPlayer.AddInputEventDelegate (StartGameForReal, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "MainAction");
	}

	void StartGame (InputActionEventData data)
	{
		if (MState == MenuState.Main) {
			MState = MenuState.HowTo;
			GO_MainMenu.SetActive (false);
			GO_HowToPlay.SetActive (true);
		}

	}

	void StartGameForReal (InputActionEventData data)
	{
		if (MState == MenuState.HowTo) {
			MState = MenuState.Starting;
			GO_HowToPlay.SetActive (false);
			Destroy (GO_RewiredManager);
			SceneManager.LoadScene ("LD_Final");
			//LoadLevel
		}


	}

	void Credits (InputActionEventData data)
	{
		if (MState == MenuState.Credit) {
			MState = MenuState.Main;
			GO_Credits.SetActive (false);
			GO_MainMenu.SetActive (true);
		} else if (MState != MenuState.HowTo) {
			MState = MenuState.Credit;
			GO_Credits.SetActive (true);
			GO_MainMenu.SetActive (false);
		}

	}
}
