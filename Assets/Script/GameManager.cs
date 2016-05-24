using UnityEngine;
using System.Collections;
using Rewired;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : Singleton<GameManager>
{
	public delegate void DeathActions ();

	public static event DeathActions Death;

	public GameObject Player1;
	public GameObject Player2;

	[SerializeField]
	private GameObject FirstCheckPoint;
	[SerializeField]
	private GameObject LightPrefab;
	[SerializeField]
	private GameObject GameOverUI;
	[SerializeField]
	private GameObject DeepTextGO;
	[SerializeField]
	private float DeathShakeDuration = 0.8f;
	[SerializeField]
	private float DeathShakePower = 0.5f;

	public GameObject GameCamera;

	private Text TextUI;

	private GameObject Checkpoint;
	private float Deepness;
	private Player Player1_Local;
	public bool IHadLight = true;

	void Start ()
	{
		Player1_Local = ReInput.players.GetPlayer (0);
		Checkpoint = FirstCheckPoint;
		TextUI = DeepTextGO.GetComponent<Text> ();
		TPAtLastCheckPoint ();
		DOTween.Init ();
	}

	public void SetCheckpoint (GameObject TempCheckpoint)
	{
		Checkpoint = TempCheckpoint;
	}

	public void PiegePlayerDie (int ID)
	{
		if (ID == 1) {
			Player1.GetComponent<PlayerScript> ().YouDie ();
		}
		if (ID == 2) {
			Player2.GetComponent<PlayerScript> ().YouDie ();
		}
	}


	public void OnPlayerDied ()
	{
		//GameOverScreen
		if (Player1.transform.position.y < Player2.transform.position.y) {
			Deepness = Mathf.Round (Mathf.Abs (Player1.transform.position.y)); 
		} else if (Player2.transform.position.y < Player1.transform.position.y) {
			Deepness = Mathf.Round (Mathf.Abs (Player2.transform.position.y)); 
		} else if (Player1.transform.position.y == Player2.transform.position.y) {
			Deepness = Mathf.Round (Mathf.Abs (Player1.transform.position.y)); 
		}
		GameCamera.transform.DOShakePosition (DeathShakeDuration, DeathShakePower);
		Player1.GetComponent<PlayerScript> ().ResetPlayer ();
		Player2.GetComponent<PlayerScript> ().ResetPlayer ();
		TextUI.text = Deepness.ToString () + " m";
		GameOverUI.SetActive (true);
		Player1_Local.AddInputEventDelegate (WaitForA, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Jump");
		Death ();
		//TPAtLastCheckPoint ();
	}

	public void WaitForA (InputActionEventData data)
	{
		Player1_Local.RemoveInputEventDelegate (WaitForA, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "Jump");
		GameOverUI.SetActive (false);
		Player1.GetComponent<PlayerScript> ().Continue ();
		Player2.GetComponent<PlayerScript> ().Continue ();
		TPAtLastCheckPoint ();
	}

	void TPAtLastCheckPoint ()
	{
		Player1.transform.position = Checkpoint.GetComponent<Checkpoint> ().SpawnPoint_Player1.transform.position;
		Player2.transform.position = Checkpoint.GetComponent<Checkpoint> ().SpawnPoint_Player2.transform.position;
		if (IHadLight || Checkpoint.GetComponent<Checkpoint> ().ForceLight) {
			GameObject Light = Instantiate (LightPrefab, Checkpoint.GetComponent<Checkpoint> ().SpawnPoint_Light.transform.position, this.transform.rotation) as GameObject;
			if (Checkpoint == FirstCheckPoint) {
				Light.GetComponentInChildren<LightScript> ().SetTutoOn ();
			} else {
				Light.GetComponentInChildren<LookAtGameobject> ().enabled = false;
			}
		}
		IHadLight = false;
	}



}
