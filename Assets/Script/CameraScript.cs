using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CameraScript : MonoBehaviour
{


	private GameObject Player1;
	private GameObject Player2;

	void Awake ()
	{
		DOTween.Init ();
	}

	void Start ()
	{
		Player1 = GameManager.Instance.Player1;
		Player2 = GameManager.Instance.Player2;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		Vector3 PositionToGo = new Vector3 (((Player2.transform.position.x - Player1.transform.position.x) / 2f) + Player1.transform.position.x, ((Player2.transform.position.y - Player1.transform.position.y) / 2f) + Player1.transform.position.y, this.transform.position.z);

		this.transform.DOMove (PositionToGo, 0.1f, false);

		//	this.transform.position = 
	}
}
