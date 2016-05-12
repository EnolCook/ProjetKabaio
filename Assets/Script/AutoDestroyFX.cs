using UnityEngine;
using System.Collections;

public class AutoDestroyFX : MonoBehaviour
{
	
	private ParticleSystem MyPSystem;

	void Start ()
	{
		MyPSystem = this.GetComponent<ParticleSystem> ();
	}

	void Update ()
	{
		if (MyPSystem) {
			if (!MyPSystem.IsAlive ()) {
				Destroy (this.gameObject);
			}
		}
	}


}
