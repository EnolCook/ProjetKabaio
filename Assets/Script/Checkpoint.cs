using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{

	public GameObject SpawnPoint_Player1;
	public GameObject SpawnPoint_Player2;
	public GameObject SpawnPoint_Light;

	public bool ForceLight = false;

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.tag == "P1" || Thing.tag == "P2") {
			GameManager.Instance.SetCheckpoint (this.gameObject);
		}
	}
}
