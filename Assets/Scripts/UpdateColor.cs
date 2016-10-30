using UnityEngine;
using System.Collections;

public class UpdateColor : MonoBehaviour {
	Transform car;
	// Use this for initialization
	private float timeInterval = 0F;
	private bool beginTrans = false;

	Gradient g = new Gradient();
	GradientColorKey[] gck = new GradientColorKey[2];
	GradientAlphaKey[] gak = new GradientAlphaKey[2];

	void Start () {
		car = GetComponent<Transform> ();
		gck[0].time = 0.0F;
		gck[1].time = 1.0F;
		gak[0].time = 0.0F;
		gak[1].time = 1.0F;
	}

	void Update () {
		if(beginTrans) {
			timeInterval += 0.05F;

			UpdateChildColor (car, g.Evaluate(timeInterval));
		}
	}

	void OnCollisionEnter(Collision collision) {
		GameObject go = collision.gameObject;
		Renderer rendere = go.GetComponent<Renderer> ();

		gck[0].color = getCurrentColor(car);
		gck[1].color = rendere.material.color;

		gak[0].alpha = gak[1].alpha = 1.0F;
		g.SetKeys(gck, gak);

		beginTrans = true;
	}

	Color getCurrentColor(Transform parentTransform) {
		bool hg = false;
		Color currentColor = Color.white;

		foreach (Transform child in parentTransform) {
			Renderer rend = child.gameObject.GetComponent<Renderer> ();
			if (rend) {
				foreach (Material ma in rend.materials) {
					if (ma.name.Contains ("body_paint")) {
						currentColor = ma.color;
						hg = true;
						break;
					}
				}

				if (hg) {
					break;
				}
			}

		}
		return currentColor;
	}

	void UpdateChildColor (Transform parentTransform, Color newColor) {
		foreach (Transform child in parentTransform) {
			Renderer rend = child.gameObject.GetComponent<Renderer> ();
			if (rend) {
				foreach (Material ma in rend.materials) {
					if (ma.name.Contains ("body_paint")) {
						ma.SetColor ("_Color", newColor);
					}
				}
			}
			UpdateChildColor (child, newColor);
		}
	}
}
