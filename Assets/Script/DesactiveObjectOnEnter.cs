using UnityEngine;
using System.Collections;
using DG.Tweening;

public class DesactiveObjectOnEnter : MonoBehaviour
{

	[SerializeField]
	private GameObject GO_Light;

	void OnTriggerEnter (Collider thing)
	{
		if (thing.tag == "P1" || thing.tag == "P2") {
			GO_Light.GetComponent<Light> ().DOIntensity (0, 1).OnComplete (() => GO_Light.gameObject.SetActive (false));
		}
	}
}
