using UnityEngine;
using System.Collections;

public class LookAtGameobject : MonoBehaviour
{

	[SerializeField]
	private GameObject Target;

	void Start ()
	{
		if (Target == null) {
			Target = GameManager.Instance.GameCamera;
		}
	}

	void Update ()
	{
		this.gameObject.transform.LookAt (2 * this.gameObject.transform.position - Target.transform.position);
	}

	public void SetTarget (GameObject GO)
	{
		Target = GO;
	}
}
