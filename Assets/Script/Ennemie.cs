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

	GameObject LightImIn;

	void Update ()
	{
		if (LightImIn == null) {
			EnnemieLightStatus = LightStatus.NotInLight;
		} else {
			Debug.Log ("Light");
		}
	}


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

	public void SetLightYourIn (GameObject LightObject)
	{
		LightImIn = LightObject;
	}

}
