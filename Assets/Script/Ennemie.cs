using UnityEngine;
using System.Collections;

public class Ennemie : MonoBehaviour
{
	enum LightStatus
	{
		InLight,
		NotInLight
	}

	enum ZombieStatus
	{
		Idle,
		Run,
		Attack,
		Die
	}

	[SerializeField]
	private GameObject Debug;
	[SerializeField]
	LightStatus EnnemieLightStatus;

	[SerializeField]
	ZombieStatus ZombieLocalStatus;

	private NavMeshAgent Agent;
	public GameObject LightImIn;
	private bool Follow;
	private GameObject PlayerToFollow;
	private Vector3 SpawnPosition;
	private bool Dead;
	private Animator ZombieAnimator;

	[SerializeField]
	private string[] BoolList;

	private AudioSource ZombieAudio;
	[SerializeField]
	private AudioClip Death;
	[SerializeField]
	private AudioClip Walk;
	[SerializeField]
	private AudioClip[] Cri;

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
			Debug.GetComponent<BoxCollider> ().enabled = false;
			ZombieLocalStatus = ZombieStatus.Die;
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
			PlayerToFollow = GameManager.Instance.Player1.gameObject;
			Follow = true;

			PlayAudio (Cri [0], 1);
		}
		if (Thing.gameObject.CompareTag ("P2")) {
			PlayerToFollow = GameManager.Instance.Player2.gameObject;
			Follow = true;
			PlayAudio (Cri [1], 1);
		}
	}

	void UpdateStateAnim ()
	{
		if (Dead) {
			SetAnnimation ("bz_Die");
			StopAudio ();
			PlayAudio (Death, 1.5f);
		} else {
			switch (ZombieLocalStatus) {
			case ZombieStatus.Attack:
				SetAnnimation ("bz_Attack");
				break;
			case ZombieStatus.Die:
				PlayAudio (Death, 1.5f);
				SetAnnimation ("bz_Die");
				break;
			case ZombieStatus.Idle:
				SetAnnimation ("bz_Idle");
				break;
			case ZombieStatus.Run:
				PlayAudio (Walk, 0.8f);
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
		yield return new WaitForSeconds (2);
		GameManager.Death -= TPToSpawnLoc;
		Destroy (this.gameObject);
	}
}
