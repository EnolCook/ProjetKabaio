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


	void Update ()
	{
		if (LightImIn == null) {
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
		Agent = GetComponent<NavMeshAgent> ();
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
