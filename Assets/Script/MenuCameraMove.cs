using UnityEngine;
using System.Collections;
using DG.Tweening;


public class MenuCameraMove : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		DOTween.Init ();
		MoveAgain ();
	}

	void MoveAgain ()
	{
		Vector3 TempMovement = new Vector3 (this.transform.transform.position.x + Random.Range (-2, 2), this.transform.transform.position.y + Random.Range (-1f, 1f), -10);
		this.transform.DOMove (TempMovement, 10).SetEase (Ease.InOutSine).OnComplete (() => MoveAgain ());
	}
}
