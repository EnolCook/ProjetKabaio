﻿using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Checkpoint : MonoBehaviour
{

	public GameObject SpawnPoint_Player1;
	public GameObject SpawnPoint_Player2;
	public GameObject SpawnPoint_Light;

	public Light[] Lights;
	public GameObject[] GO_Lights;
	[SerializeField]
	private bool First = false;
	[SerializeField]
	private bool TutoOnLight = false;
	public bool ForceLight = false;

	private GameObject LightSpawned;

	void Start ()
	{
		if (!First) {
			foreach (Light L in Lights) {
				L.intensity = 0;
			}
			foreach (GameObject GOLight in GO_Lights) {
				GOLight.transform.DOScale (new Vector3 (0, 0, 0), 0.1f);
				GOLight.SetActive (false);
			}
		}
	}

	public void SetLightSpawned (GameObject GO)
	{
		LightSpawned = GO;
		if (First) {
			Destroy (GO);
		} else {
			if (TutoOnLight) {
				GO.GetComponentInChildren<LightScript> ().SetTutoOn ();
			} else {
				GO.GetComponentInChildren<LightScript> ().SetTutoOff ();
			}
		}
	}

	void OnTriggerEnter (Collider Thing)
	{
		if (Thing.tag == "P1" && !First || Thing.tag == "P2" && !First) {
			GameManager.Instance.SetCheckpoint (this.gameObject);
			foreach (Light L in Lights) {
				if (L.intensity == 0) {
					L.DOIntensity (0.90f, 1);
				}
			}
			foreach (GameObject GOLight in GO_Lights) {
				GOLight.SetActive (true);
				GOLight.transform.DOScale (new Vector3 (0.3f, 0.6f, 0.6f), 0.5f);

			}
		}

	}
}
