using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{

	[SerializeField]
	public GameObject SpawnPoint_Player1;
	[SerializeField]
	public GameObject SpawnPoint_Player2;
	[SerializeField]
	public GameObject SpawnPoint_Light;

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.tag == "P1" || Thing.tag == "P2") {
			GameManager.Instance.SetCheckpoint (this.gameObject);
		}
	}
}
