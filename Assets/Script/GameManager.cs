using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager>
{

	public GameObject Player1;
	public GameObject Player2;

	[SerializeField]
	private GameObject FirstCheckPoint;
	[SerializeField]
	private GameObject LightPrefab;

	private GameObject Checkpoint;
	private float Deepness;

	void Start ()
	{
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
		TPAtLastCheckPoint ();
	}

	void TPAtLastCheckPoint ()
	{
		Player1.transform.position = Checkpoint.GetComponent<Checkpoint> ().SpawnPoint_Player1.transform.position;
		Player2.transform.position = Checkpoint.GetComponent<Checkpoint> ().SpawnPoint_Player2.transform.position;
		Instantiate (LightPrefab, Checkpoint.GetComponent<Checkpoint> ().SpawnPoint_Light.transform.position, this.transform.rotation);

	}

}
