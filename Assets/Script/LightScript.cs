using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour
{

	private bool Taken = false;

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("P1")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = true;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = this.transform.parent.gameObject;
		}
		if (Thing.gameObject.CompareTag ("P2")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = true;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = this.transform.parent.gameObject;
		}
	}

	void OnTriggerExit (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("P1")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = false;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = null;
		}
		if (Thing.gameObject.CompareTag ("P2")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = false;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = null;
		}
	}
}
