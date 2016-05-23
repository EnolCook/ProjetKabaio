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
	private bool InP1 = false;
	[SerializeField]
	private bool InP2 = false;

	private Vector3 StartPos;
	private Vector3 EndPos;

	// Use this for initialization
	void Start ()
	{
		StartPos = StartPoint.transform.position;
		EndPos = EndPoint.transform.position;
		Plateforme.transform.position = StartPos;
	}

	void OnTriggerEnter (Collider Col)
	{
		Plateforme.transform.DOPause ();
		if (Col.gameObject.CompareTag ("P1")) {
			InP1 = true;
			 
		}
		if (Col.gameObject.CompareTag ("P2")) {
			InP2 = true;
		}
		if (InP1 && InP2) {
			Plateforme.transform.DOMove (EndPos, Speed, false);
		}
	}

	void OnTriggerExit (Collider Col)
	{
		Plateforme.transform.DOPause ();
		if (Col.gameObject.CompareTag ("P1")) {
			InP1 = false;
		}
		if (Col.gameObject.CompareTag ("P2")) {
			InP2 = false;
		}
	}
}
