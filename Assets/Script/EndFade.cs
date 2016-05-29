using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class EndFade : MonoBehaviour
{

	[SerializeField]
	private Image END;
	[SerializeField]
	private Image Title;
	[SerializeField]
	private float TimeToFade;

	[SerializeField]
	private bool PrezMode = false;

	void Start ()
	{
		END.DOFade (0, 8);
	}

	void OnTriggerEnter (Collider thing)
	{
		

		if (thing.tag == "P1" || thing.tag == "P2") {
			if (!PrezMode) {
				GameManager.Instance.LaunchEnd (TimeToFade);
				END.DOFade (1, TimeToFade);
			} else {
				END.DOFade (1, TimeToFade).OnComplete (() => Title.DOFade (1, 3));
			}
		}
	}
}
