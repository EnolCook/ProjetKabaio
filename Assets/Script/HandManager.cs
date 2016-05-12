using UnityEngine;
using System.Collections;
using DG.Tweening;

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
	private float LightThrowPower = 1;
	[SerializeField]
	private float ShotShakeDuration = 0.1f;
	[SerializeField]
	private float ShotShakePower = 0.2f;

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
		DOTween.Init ();
	}

	public void TakeLight (GameObject LightToTake)
	{
		InHand = Hand.Light;
		LightToTake.GetComponentInChildren<LightScript> ().OnTaken (this.gameObject.transform.parent.tag);
		SpotLight.SetActive (true);
		Shotgun.SetActive (false);
	}

	public void ResetHand ()
	{
		InHand = Hand.Shotgun;
		SpotLight.SetActive (false);
		Shotgun.SetActive (true);
	}

	public void DropLight ()
	{
		InHand = Hand.Shotgun;
		SpotLight.SetActive (false);
		Shotgun.SetActive (true);
		Instantiate (LightPrefab, Spawnpoint.transform.position, this.transform.rotation);
	}

	public void DropLightWithNoSpawn ()
	{
		InHand = Hand.Shotgun;
		SpotLight.SetActive (false);
		Shotgun.SetActive (true);
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
			if (this.transform.parent.GetComponent<PlayerScript> ().Mirrored) {
				Angle = -Angle;
				Muzzle.transform.eulerAngles = -Angle;
			}
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

		GameManager.Instance.GameCamera.transform.DOShakePosition (ShotShakeDuration, ShotShakePower);

		RaycastHit hit;

		Debug.DrawRay (Muzzle.transform.position, Muzzle.transform.up * 1000, Color.red);

		if (Physics.Raycast (Muzzle.transform.position, Muzzle.transform.up * 1000, out hit)) {
			//Debug.Log (hit.collider.gameObject.name);
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
