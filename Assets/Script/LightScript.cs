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

	public void OnTaken (string Tag)
	{
		if (Tag == "P1") {
			GameManager.Instance.Player2.GetComponent<PlayerScript> ().LocalCanTake = false;
			GameManager.Instance.Player2.GetComponent<PlayerScript> ().LightToTake = null;
		}
		if (Tag == "P2") {
			GameManager.Instance.Player1.GetComponent<PlayerScript> ().LocalCanTake = false;
			GameManager.Instance.Player1.GetComponent<PlayerScript> ().LightToTake = null;
		}
		Destroy (this.gameObject.transform.parent.gameObject);
	}
}
