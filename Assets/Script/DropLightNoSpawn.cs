using UnityEngine;
using System.Collections;

public class DropLightNoSpawn : MonoBehaviour
{

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.tag == "P1" || Thing.tag == "P2") {
			Thing.gameObject.GetComponentInChildren<HandManager> ().DropLightWithNoSpawn ();
		}

	}
}
