﻿using UnityEngine;
using System.Collections;
using Rewired;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class NewMenuManager : MonoBehaviour
{
	public int PlayerID;
	private Player LocalPlayer;
	[SerializeField]
	private GameObject PlayButton;
	[SerializeField]
	private GameObject CreditsButton;
	[SerializeField]
	private GameObject QuitButton;
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

	private bool InMenu = false;

	private AudioSource LocalAudio;

	public enum MainMenuStates
	{
		Play,
		Credits,
		Quit
	}

	public MainMenuStates LocalMainStateMenu;

	void Awake ()
	{
		DOTween.Init ();
		LocalPlayer = ReInput.players.GetPlayer (PlayerID);
		LocalPlayer.AddInputEventDelegate (Up, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "UP");
		LocalPlayer.AddInputEventDelegate (Down, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "DOWN");
		LocalPlayer.AddInputEventDelegate (Select, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "SELECT");
	}

	void Start ()
	{
		LocalAudio = this.gameObject.GetComponent<AudioSource> ();
		CurAxis = new AxisEventData (EventSystem.current);
		myEventSystem = GameObject.Find ("EventSystem");
		UpdateState (MainMenuStates.Play);
	}

	void Up (InputActionEventData data)
	{
		if (!InMenu) {
			switch (LocalMainStateMenu) {
			case MainMenuStates.Credits:
				UpdateState (MainMenuStates.Play);
				break;
			case MainMenuStates.Play:
				UpdateState (MainMenuStates.Quit);
				break;
			case MainMenuStates.Quit:
				UpdateState (MainMenuStates.Credits);
				break;
			}
		}
	}

	void Down (InputActionEventData data)
	{
		if (!InMenu) {
			switch (LocalMainStateMenu) {
			case MainMenuStates.Credits:
				UpdateState (MainMenuStates.Quit);
				break;
			case MainMenuStates.Play:
				UpdateState (MainMenuStates.Credits);
				break;
			case MainMenuStates.Quit:
				UpdateState (MainMenuStates.Play);
				break;
			}
		}
	}

	public void Play ()
	{
		InMenu = true;
		LocalAudio.DOFade (0, 2);
		GO_MainMenu.SetActive (false);
		GO_Credits.SetActive (false);
		GO_HowToPlay.SetActive (true);
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (null);
	}

	public void Credits ()
	{
		InMenu = true;
		GO_MainMenu.SetActive (false);
		GO_Credits.SetActive (true);
		GO_HowToPlay.SetActive (false);
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (null);
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
			InMenu = false;
			GO_MainMenu.SetActive (true);
			GO_Credits.SetActive (false);
			GO_HowToPlay.SetActive (false);
			myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (null);
		}
	}

	public void UpdateState (MainMenuStates TargetState)
	{
		LocalMainStateMenu = TargetState;
		switch (LocalMainStateMenu) {
		case MainMenuStates.Credits:
			myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (CreditsButton);
			break;
		case MainMenuStates.Play:
			myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (PlayButton);
			break;
		case MainMenuStates.Quit:
			myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem> ().SetSelectedGameObject (QuitButton);
			break;
		}

	}

	public void QuitGame ()
	{
		Application.Quit ();
	}
}
