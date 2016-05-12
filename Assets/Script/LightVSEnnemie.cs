using UnityEngine;
using System.Collections;

public class LightVSEnnemie : MonoBehaviour
{

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("Ennemie")) {
			Vector3 StartPos = this.gameObject.transform.position;
			Vector3 Direction = Thing.transform.position - this.gameObject.transform.position;

			RaycastHit hit;
			//Debug.DrawRay (StartPos, Direction, Color.red, 1);
			if (Physics.Raycast (StartPos, Direction * 1000, out hit)) {
				if (hit.collider.gameObject.CompareTag ("Ennemie") && hit.collider.gameObject.tag != "Debug") {
					if (Thing.gameObject.GetComponent<Ennemie> () != null) {
						Thing.gameObject.GetComponent<Ennemie> ().IsInLight ();
						Thing.gameObject.GetComponent<Ennemie> ().SetLightYourIn (this.gameObject);
					}

				}
			}
		}
	}

	void OnTriggerExit (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("Ennemie") && !Thing.gameObject.CompareTag ("Debug")) {
			if (Thing.gameObject.GetComponent<Ennemie> () != null) {
				Thing.gameObject.GetComponent<Ennemie> ().IsNotInLight ();
				Thing.gameObject.GetComponent<Ennemie> ().SetLightYourIn (null);
			}
		}
	}

	//Raycast at every tick OnStay is not that great but it works and perf are still great. To Change if Time and Usage.
	void OnTriggerStay (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("Ennemie")) {
			Vector3 StartPos = this.gameObject.transform.position;
			Vector3 Direction = Thing.transform.position - this.gameObject.transform.position;

			RaycastHit hit;
			//Debug.DrawRay (StartPos, Direction, Color.red, 1);
			if (Physics.Raycast (StartPos, Direction * 1000, out hit)) {
				
				if (hit.collider.gameObject.tag == "Ennemie") {
					if (Thing.gameObject.GetComponent<Ennemie> () != null) {
						Thing.gameObject.GetComponent<Ennemie> ().IsInLight ();
						Thing.gameObject.GetComponent<Ennemie> ().SetLightYourIn (this.gameObject);
					}
				} else if (Thing.gameObject.tag != "Debug") {
					Thing.gameObject.GetComponent<Ennemie> ().IsNotInLight ();

				}
			}
		}
	}
}
