using UnityEngine;
using System.Collections;

public class UpdateColor : MonoBehaviour {
	Transform car;
	// Use this for initialization
	void Start () {
		car = GetComponent<Transform> ();
		Transform[] children = car.GetComponentsInChildren<Transform>();
		print (children[0]);
//		Renderer rend = GetComponent<Renderer>();
//		foreach (Material ma in rend.materials) {
//			if(ma.name.Contains("body_paint")) {
//				ma.SetColor ("_Color", Color.red);
//			}
//		}
//		rend.material.shader = Shader.Find("Specular");
//		rend.material.SetColor("_SpecColor", Color.red);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
