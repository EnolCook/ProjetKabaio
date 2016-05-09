using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{


	[SerializeField]
	private GameObject Player1;

	[SerializeField]
	private GameObject Player2;

	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position = new Vector3 (((Player2.transform.position.x - Player1.transform.position.x) / 2f) + Player1.transform.position.x, ((Player2.transform.position.y - Player1.transform.position.y) / 2f) + Player1.transform.position.y, this.transform.position.z);
	}
}
