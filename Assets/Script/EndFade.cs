using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class EndFade : MonoBehaviour
{

	[SerializeField]
	private Image END;
	[SerializeField]
	private float TimeToFade;

	void OnTriggerEnter (Collider thing)
	{
		GameManager.Instance.LaunchEnd (TimeToFade);
		if (thing.tag == "P1" || thing.tag == "P2") {
			END.DOFade (1, TimeToFade);
		}
	}
}
