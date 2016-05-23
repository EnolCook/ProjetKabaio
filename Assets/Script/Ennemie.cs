using UnityEngine;
using System.Collections;

public class Ennemie : MonoBehaviour
{
	public enum LightStatus
	{
		InLight,
		NotInLight
	}

	public enum ZombieStatus
	{
		Idle,
		Run,
		Attack,
		Die
	}

	[SerializeField]
	private GameObject GO_Debug;

	public LightStatus EnnemieLightStatus;


	public ZombieStatus ZombieLocalStatus;

	private NavMeshAgent Agent;
	public GameObject LightImIn;
	private bool Follow;
	private GameObject PlayerToFollow;
	private Vector3 SpawnPosition;
	private bool Dead;
	private Animator ZombieAnimator;

	[SerializeField]
	private float AttackSoundDistance;
	[SerializeField]
	private float DistanceNoSound = 10;
	[SerializeField]
	private string[] BoolList;
	private AudioSource ZombieAudio;
	[SerializeField]
	private AudioClip Death;
	[SerializeField]
	private AudioClip Walk;
	[SerializeField]
	private AudioClip[] Cri;

	private float dist;

	void Update ()
	{
		UpdateStateAnim ();
		if (LightImIn == null || LightImIn.activeSelf == false) {
			EnnemieLightStatus = LightStatus.NotInLight;
		}
		if (LightImIn != null && LightImIn.name != "Spotlight") {
			if (!LightImIn.GetComponent<SphereCollider> ().enabled) {
				EnnemieLightStatus = LightStatus.NotInLight;
			}
		}

		if (Follow) {
			FollowUntilDED ();
		}
		if (this.Agent.velocity == Vector3.zero) {
			ZombieLocalStatus = ZombieStatus.Idle;
		}
		if (PlayerToFollow != null) {

			dist = Vector3.Distance (PlayerToFollow.gameObject.transform.position, this.gameObject.transform.position);
			if (dist > DistanceNoSound) {
				StopAudio ();
			}
			if (dist < AttackSoundDistance) {
				ZombieLocalStatus = ZombieStatus.Attack;
			}
		}

	}

	void FollowUntilDED ()
	{
		Agent.SetDestination (PlayerToFollow.transform.position);
		ZombieLocalStatus = ZombieStatus.Run;
	}

	void Start ()
	{
		ZombieAudio = this.GetComponent<AudioSource> ();
		GameManager.Death += TPToSpawnLoc;
		ZombieAnimator = this.GetComponentInChildren<Animator> ();
		Agent = GetComponent<NavMeshAgent> ();
		SpawnPosition = this.transform.position;
	}

	public void Die ()
	{
		if (EnnemieLightStatus == LightStatus.InLight) {
			Dead = true;
			Agent.Stop ();
			this.GetComponent<CapsuleCollider> ().enabled = false;
			GO_Debug.GetComponent<BoxCollider> ().enabled = false;
			ZombieLocalStatus = ZombieStatus.Die;
			StopAudio ();
			PlayAudio (Death, 1f);
			StartCoroutine ("DieTemp");

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
		StopAudio ();
		ZombieLocalStatus = ZombieStatus.Idle;
		this.transform.position = SpawnPosition;
		Agent.SetDestination (SpawnPosition);
		PlayerToFollow = null;
		Follow = false;
	}

	void OnTriggerEnter (Collider Thing)
	{
		
		if (Thing.gameObject.CompareTag ("P1")) {
			PlayAudio (Cri [0], 1);
			PlayerToFollow = GameManager.Instance.Player1.gameObject;
			Follow = true;

		}
		if (Thing.gameObject.CompareTag ("P2")) {
			PlayAudio (Cri [0], 1);
			PlayerToFollow = GameManager.Instance.Player2.gameObject;
			Follow = true;

		}
	}

	void UpdateStateAnim ()
	{
		if (Dead) {
			SetAnnimation ("bz_Die");
		} else {
			switch (ZombieLocalStatus) {
			case ZombieStatus.Attack:
				SetAnnimation ("bz_Attack");
				PlayAudio (Cri [1], 1);
				break;
			case ZombieStatus.Die:
				PlayAudio (Death, 1.5f);
				SetAnnimation ("bz_Die");
				break;
			case ZombieStatus.Idle:
				SetAnnimation ("bz_Idle");
				break;
			case ZombieStatus.Run:
				if (dist < DistanceNoSound) {
					PlayAudio (Walk, 0.8f);
				}
				SetAnnimation ("bz_Run");
				break;
			}
		}
	}

	void SetAnnimation (string AnimState)
	{
		foreach (string ST in BoolList) {
			if (ST != AnimState) {
				ZombieAnimator.SetBool (ST, false);
			} else {
				ZombieAnimator.SetBool (AnimState, true);
			}
		}
	}

	public void PlayAudio (AudioClip ToPlay, float Vol)
	{
		if (ZombieAudio.isPlaying == false) {
			ZombieAudio.PlayOneShot (ToPlay, Vol);
		}

	}

	public void StopAudio ()
	{
		ZombieAudio.Stop ();
	}

	IEnumerator DieTemp ()
	{
		GameManager.Death -= TPToSpawnLoc;
		yield return new WaitForSeconds (10);
		Destroy (this.gameObject);
	}
}
