using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ChangeAmbienceSound : MonoBehaviour
{

	[SerializeField]
	private AudioSource AbianceSource;

	[SerializeField]
	private AudioClip Surface;
	[SerializeField]
	private AudioClip Mine;

	private bool DoOnce = true;

	// Use this for initialization
	void Start ()
	{
		AbianceSource.Stop ();
		AbianceSource.clip = Surface;
		AbianceSource.Play ();
	}


	void OnTriggerEnter (Collider thing)
	{
		if (thing.tag == "P1" && DoOnce || thing.tag == "P2" && DoOnce) {
			DoOnce = false;
			AbianceSource.DOFade (0, 3).OnComplete (() => {
				AbianceSource.Stop ();
				AbianceSource.clip = Mine;
				AbianceSource.Play ();
				AbianceSource.DOFade (1, 1);
			});
		}
	}

}
