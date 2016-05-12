using UnityEngine;
using System.Collections;

public class DieZone : MonoBehaviour
{

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("P1") || Thing.gameObject.CompareTag ("P2")) {
			if (Thing.gameObject.CompareTag ("P1")) {
				GameManager.Instance.PiegePlayerDie (1);
			}
			if (Thing.gameObject.CompareTag ("P2")) {
				GameManager.Instance.PiegePlayerDie (2);
			}

		}
	}
}
