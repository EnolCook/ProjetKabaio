using UnityEngine;
using System.Collections;
using Rewired;

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

	private GameObject Checkpoint;
	private float Deepness;
	private Player Player1_Local;
	public bool IHadLight = true;

	void Start ()
	{
		Player1_Local = ReInput.players.GetPlayer (0);
		Checkpoint = FirstCheckPoint;
		TPAtLastCheckPoint ();
	}

	public void SetCheckpoint (GameObject TempCheckpoint)
	{
		Checkpoint = TempCheckpoint;
	}

	public void OnPlayerDied ()
	{
		//GameOverScreen
		Player1.GetComponent<PlayerScript> ().ResetPlayer ();
		Player2.GetComponent<PlayerScript> ().ResetPlayer ();
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
		if (IHadLight) {
			Instantiate (LightPrefab, Checkpoint.GetComponent<Checkpoint> ().SpawnPoint_Light.transform.position, this.transform.rotation);
		}
		IHadLight = false;
	}



}
