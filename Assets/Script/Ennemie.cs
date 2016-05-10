using UnityEngine;
using System.Collections;

public class Ennemie : MonoBehaviour
{
	enum LightStatus
	{
		InLight,
		NotInLight
	}

	[SerializeField]
	LightStatus EnnemieLightStatus;


	public void Die ()
	{
		if (EnnemieLightStatus == LightStatus.InLight) {
			Destroy (this.gameObject);
		}
	}

	public void IsInLight ()
	{
		EnnemieLightStatus = LightStatus.InLight;
	}

	public void IsNotInLight ()
	{
		EnnemieLightStatus = LightStatus.NotInLight;
	}
}
