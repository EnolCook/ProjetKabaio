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
	private GameObject Spawnpoint;
	[SerializeField]
	private GameObject Muzzle;
	[SerializeField]
	private float ShotgunRealoadTime = 2;
	[SerializeField]
	private LayerMask LayerShotGun;
	[SerializeField]
	private float LightThrowPower = 1;

	private int int_ShotGun = 2;


	private Vector3 TempAngle;




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
		Instantiate (LightPrefab, Spawnpoint.transform.position, this.transform.rotation);
	}

	void LaunchLight ()
	{
		InHand = Hand.Shotgun;
		SpotLight.SetActive (false);
		Shotgun.SetActive (true);
		GameObject LightTrowed = Instantiate (LightPrefab, Spawnpoint.transform.position, this.transform.rotation) as GameObject;
		LightTrowed.GetComponent<Rigidbody> ().AddForce (Spawnpoint.transform.TransformDirection (Vector3.forward) * (LightThrowPower * 100));
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
			TempAngle = Angle;
			SpotLight.transform.localEulerAngles = Angle;
		}
		if (InHand == Hand.Shotgun) {
			Vector3 Angle = new Vector3 (0, 0, -StickValue);
			TempAngle = Angle;
			Shotgun.transform.localEulerAngles = Angle;
		}
	}

	public void HandAction ()
	{
		
		if (InHand == Hand.Shotgun) {
			if (int_ShotGun > 0) {
				int_ShotGun--;
				RayShotgun ();
				if (int_ShotGun == 0) {
					StartCoroutine ("Reload");
				}
			}
		}
		if (InHand == Hand.Light) {
			LaunchLight ();
		}
	}



	void RayShotgun ()
	{
		RaycastHit hit;
		//Replace ShotgunPosition with muzzle position
		Debug.DrawRay (Muzzle.transform.position, Muzzle.transform.up * 10, Color.red);

		if (Physics.Raycast (Muzzle.transform.position, Muzzle.transform.up * 1000, out hit, LayerShotGun)) {
			Debug.Log (hit.collider.gameObject.name);
			if (hit.collider.gameObject.CompareTag ("Ennemie")) {
				Ennemie EnnemieScript = hit.collider.gameObject.GetComponent<Ennemie> ();
				EnnemieScript.Die ();
			}
		}
	}

	IEnumerator Reload ()
	{
		yield return new WaitForSeconds (ShotgunRealoadTime);
		int_ShotGun = 2;
	}
		

}
