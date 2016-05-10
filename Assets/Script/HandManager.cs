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
	[SerializeField]
	private GameObject Muzzle;

	private Vector3 TempShotgun;
	private float ShotGunCD;

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

	public void InputWork (float AxisX, float AxisY)
	{
		if (AxisX != 0.0f || AxisY != 0.0f) {
			float StickValue = Mathf.Atan2 (AxisX, AxisY) * 180 / Mathf.PI;
			MoveHand (StickValue);
		}

	}

	void MoveHand (float StickValue)
	{
		if (InHand == Hand.Light) {
			Vector3 Angle = new Vector3 (StickValue - 90, 0, 0);
			SpotLight.transform.localEulerAngles = Angle;
		}
		if (InHand == Hand.Shotgun) {
			Vector3 Angle = new Vector3 (0, 0, -StickValue);
			TempShotgun = Angle;
			Shotgun.transform.localEulerAngles = Angle;
		}
	}

	public void HandAction ()
	{
		if (InHand == Hand.Light) {

		}
		if (InHand == Hand.Shotgun) {
			RayShotgun ();
		}
	}

	void RayShotgun ()
	{
		RaycastHit hit;
		//Replace ShotgunPosition with muzzle position
		Debug.DrawRay (Muzzle.transform.position, Muzzle.transform.up * 10, Color.red);
		if (Physics.Raycast (Muzzle.transform.position, Muzzle.transform.up * 1000, out hit)) {
			//Debug.Log (hit.collider.gameObject.name);
			if (hit.collider.gameObject.CompareTag ("Ennemie")) {
				Ennemie EnnemieScript = hit.collider.gameObject.GetComponent<Ennemie> ();
				EnnemieScript.Die ();
			}
		}
	}
}
