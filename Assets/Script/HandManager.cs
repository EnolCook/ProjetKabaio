using UnityEngine;
using System.Collections;

public class HandManager : MonoBehaviour
{

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
	}

	public void DropLight ()
	{
		InHand = Hand.Shotgun;
	}

}
