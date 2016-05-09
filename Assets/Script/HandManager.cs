using UnityEngine;
using System.Collections;

public class HandManager : MonoBehaviour
{

	[SerializeField]
	private GameObject Shotgun;
	[SerializeField]
	private GameObject SpotLight;
	[SerializeField]
	private GameObject LightPrefab;

	public enum Hand
	{
		Light,
		Shotgun
	}

	public Hand InHand;


	void Start ()
	{
		InHand = Hand.Shotgun;
	}

	public void TakeLight (GameObject LightToTake)
	{
		InHand = Hand.Light;
		Destroy (LightToTake);
		SpotLight.SetActive (true);
		Shotgun.SetActive (false);
	}

	public void DropLight ()
	{
		InHand = Hand.Shotgun;
		SpotLight.SetActive (false);
		Shotgun.SetActive (true);
		Instantiate (LightPrefab, this.transform.position, this.transform.rotation);
	}

}
