using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Ascenseur : MonoBehaviour
{
	[SerializeField]
	private GameObject Plateforme;
	[SerializeField]
	private GameObject StartPoint;
	[SerializeField]
	private GameObject EndPoint;
	[SerializeField]
	[Tooltip ("This is the time in second to go from start to end")]
	private float Speed;
	[SerializeField]
	private float WaitTime;
	[SerializeField]
	private bool InP1 = false;
	[SerializeField]
	private bool InP2 = false;
	[SerializeField]
	private AudioClip AscenseurAudio;

	private AudioSource LocalAudioSource;

	private Vector3 StartPos;
	private Vector3 EndPos;

	// Use this for initialization
	void Start ()
	{
		GameManager.Death += ResetAscenseur;
		LocalAudioSource = this.gameObject.GetComponent<AudioSource> ();
		StartPos = StartPoint.transform.position;
		EndPos = EndPoint.transform.position;
		Plateforme.transform.position = StartPos;
	}

	void ResetAscenseur ()
	{
		Plateforme.transform.position = StartPos;
	}


	void OnTriggerEnter (Collider Col)
	{
		
		if (Col.gameObject.CompareTag ("P1")) {
			InP1 = true; 
			Plateforme.transform.DOPause ();
			LocalAudioSource.Stop ();
		}
		if (Col.gameObject.CompareTag ("P2")) {
			InP2 = true;
			Plateforme.transform.DOPause ();
			LocalAudioSource.Stop ();
		}
		if (InP1 && InP2) {
			StartCoroutine ("MoveAscenseur");
		}
	}

	void OnTriggerExit (Collider Col)
	{
		
		if (Col.gameObject.CompareTag ("P1")) {
			InP1 = false;
			Plateforme.transform.DOPause ();
			LocalAudioSource.Stop ();
		}
		if (Col.gameObject.CompareTag ("P2")) {
			InP2 = false;
			Plateforme.transform.DOPause ();
			LocalAudioSource.Stop ();
		}
	}

	void Arrived ()
	{
		StartCoroutine ("FadeMusic");
	}

	IEnumerator MoveAscenseur ()
	{
		yield return new WaitForSeconds (WaitTime);
		LocalAudioSource.PlayOneShot (AscenseurAudio, 0.8f);
		Plateforme.transform.DOMove (EndPos, Speed, false).SetEase (Ease.InOutSine).OnComplete (() => Arrived ());
	}

	IEnumerator FadeMusic ()
	{
		while (LocalAudioSource.volume > .1F) {
			LocalAudioSource.volume = Mathf.Lerp (LocalAudioSource.volume, 0F, Time.deltaTime);
			yield return 0;
		}
		LocalAudioSource.volume = 0;
		LocalAudioSource.Stop ();
	}
}
