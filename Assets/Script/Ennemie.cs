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

	private NavMeshAgent Agent;
	public GameObject LightImIn;
	private bool Follow;
	private GameObject PlayerToFollow;
	private Vector3 SpawnPosition;


	void Update ()
	{
		if (LightImIn == null || LightImIn.activeSelf == false) {
			EnnemieLightStatus = LightStatus.NotInLight;
		}
		if (LightImIn != null && !LightImIn.GetComponent<SphereCollider> ().enabled) {
			EnnemieLightStatus = LightStatus.NotInLight;
		}
		if (Follow) {
			FollowUntilDED ();
		}
	}

	void FollowUntilDED ()
	{
		Agent.SetDestination (PlayerToFollow.transform.position);
	}

	void Start ()
	{
		GameManager.Death += TPToSpawnLoc;

		Agent = GetComponent<NavMeshAgent> ();
		SpawnPosition = this.transform.position;
	}

	public void Die ()
	{
		if (EnnemieLightStatus == LightStatus.InLight) {
			GameManager.Death -= TPToSpawnLoc;
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

	void TPToSpawnLoc ()
	{
		this.transform.position = SpawnPosition;
		Agent.SetDestination (SpawnPosition);
		PlayerToFollow = null;
		Follow = false;
	}

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.gameObject.CompareTag ("P1")) {
			PlayerToFollow = GameManager.Instance.Player1.gameObject;

			Follow = true;
		}
		if (Thing.gameObject.CompareTag ("P2")) {
			PlayerToFollow = GameManager.Instance.Player2.gameObject;
			Follow = true;
		}
	}
}
