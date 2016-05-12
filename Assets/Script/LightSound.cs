using UnityEngine;
using System.Collections;

public class LightSound : MonoBehaviour
{
	[SerializeField]
	private AudioClip Throw;

	void OnCollisionEnter (Collision Thing)
	{
		this.GetComponent<AudioSource> ().PlayOneShot (Throw);
	}
}