using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Ascenseur : MonoBehaviour
{

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
		this.transform.position = StartPos;
	}

	void OnTriggerEnter (Collider Col)
	{
		this.transform.DOPause ();
		if (Col.gameObject.CompareTag ("P1")) {
			InP1 = true;

		}
		if (Col.gameObject.CompareTag ("P2")) {
			InP2 = true;
		}
		if (InP1 && InP2) {
			this.transform.DOMove (EndPos, Speed, false);
		}

	}

}
