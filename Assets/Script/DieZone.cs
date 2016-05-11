using UnityEngine;
using System.Collections;

public class DieZone : MonoBehaviour
{

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("P1") || Thing.gameObject.CompareTag ("P2")) {
			GameManager.Instance.OnPlayerDied ();
		}
	}
}
