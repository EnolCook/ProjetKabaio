using UnityEngine;
using System.Collections;

public class LightSound : MonoBehaviour
{
	[SerializeField]
	private AudioClip Throw;
	[SerializeField]
	private bool IWasPutHereByHand = false;

	void OnCollisionEnter (Collision Thing)
	{
		if (!IWasPutHereByHand) {
			this.GetComponent<AudioSource> ().PlayOneShot (Throw);
		}
	}
}