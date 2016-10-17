using UnityEngine;
using System.Collections;

public class UpdateColor : MonoBehaviour {
	Transform car;
	// Use this for initialization
	void Start () {
		car = GetComponent<Transform> ();
		UpdateChildColor (car, Color.red);
	}

	void Update () {
	
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
