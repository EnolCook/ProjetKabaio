using UnityEngine;
using System.Collections;

public class Chlight : MonoBehaviour
{
	private SphereCollider ChlightCollider;
	private Light ChlightLight;


	[SerializeField]
	[Range (0.0f, 20)]
	private float Range = 10;

	[SerializeField]
	private float TimeOn;
	[SerializeField]
	private float TimeOff;
	// Use this for initialization
	void Start ()
	{
		ChlightCollider = this.GetComponent<SphereCollider> ();
		ChlightLight = this.GetComponent<Light> ();
		ChlightCollider.radius = Range;
		ChlightLight.range = Range;
		StartCoroutine ("LightBugSystem");
	}

	void TurnOn ()
	{
		ChlightLight.enabled = true;
		ChlightCollider.enabled = true;
	}

	void TurnOff ()
	{
		ChlightLight.enabled = false;
		ChlightCollider.enabled = false;
	}


	IEnumerator LightBugSystem ()
	{
		while (true) {
			TurnOn ();
			yield return new WaitForSeconds (TimeOn);
			TurnOff ();
			yield return new WaitForSeconds (TimeOff);
		}

	}

}
