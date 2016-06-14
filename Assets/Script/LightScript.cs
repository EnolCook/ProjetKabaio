using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LightScript : MonoBehaviour
{

	[SerializeField]
	private GameObject GO_Tuto;
	[SerializeField]
	private bool Tuto = false;

	private bool Taken = false;

	private bool InP1 = false;
	private bool InP2 = false;

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("P1")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = true;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = this.transform.parent.gameObject;
			InP1 = true;
		}
		if (Thing.gameObject.CompareTag ("P2")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = true;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = this.transform.parent.gameObject;
			InP2 = true;
		}
		if (Tuto && Thing.gameObject.CompareTag ("P1") || Tuto && Thing.gameObject.CompareTag ("P2")) {
			GO_Tuto.SetActive (true);
			GO_Tuto.transform.DOScale (new Vector3 (1, 1, 1), 0.5f);
		}
	}

	void OnTriggerExit (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("P1")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = false;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = null;
			InP1 = false;
		}
		if (Thing.gameObject.CompareTag ("P2")) {
			Thing.gameObject.GetComponent<PlayerScript> ().LocalCanTake = false;
			Thing.gameObject.GetComponent<PlayerScript> ().LightToTake = null;
			InP2 = false;
		}
		if (Tuto && Thing.gameObject.CompareTag ("P1") || Tuto && Thing.gameObject.CompareTag ("P2")) {
			if (!InP1 && !InP2)
				GO_Tuto.transform.DOScale (new Vector3 (0, 0, 0), 0.5f).OnComplete (() => GO_Tuto.SetActive (false));
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

	public void SetTutoOn ()
	{
		Tuto = true;
	}

	public void SetTutoOff ()
	{
		//this.gameObject.GetComponentInChildren<LookAtGameobject> ().enabled = false;
		//We should disable LookAtObject Script on the Tuto's Canvas to gain perf. If we have time / if we drop at 10 fps.
	}
}
