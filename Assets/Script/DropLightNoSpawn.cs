using UnityEngine;
using System.Collections;

public class DropLightNoSpawn : MonoBehaviour
{
	[SerializeField]
	private AudioClip LightBreak;

	private AudioSource ThisAudioSource;


	void Start ()
	{
		ThisAudioSource = this.gameObject.GetComponent<AudioSource> ();
	}

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.tag == "P1" || Thing.tag == "P2") {
			
			if (Thing.gameObject.GetComponentInChildren<HandManager> ().InHand == HandManager.Hand.Light) {
				Thing.gameObject.GetComponentInChildren<HandManager> ().DropLightWithNoSpawn ();
				ThisAudioSource.PlayOneShot (LightBreak, 1);
			}

		}

	}
}
