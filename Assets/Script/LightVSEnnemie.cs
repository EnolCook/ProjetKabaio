using UnityEngine;
using System.Collections;

public class LightVSEnnemie : MonoBehaviour
{

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("Ennemie")) {
			Thing.gameObject.GetComponent<Ennemie> ().IsInLight ();
		}
	}

	void OnTriggerExit (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("Ennemie")) {
			Thing.gameObject.GetComponent<Ennemie> ().IsNotInLight ();
		}
	}

	void OnTriggerStay (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("Ennemie")) {
			Thing.gameObject.GetComponent<Ennemie> ().IsInLight ();
		}
	}
}
