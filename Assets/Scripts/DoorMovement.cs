using UnityEngine;
using System.Collections;

public class DoorMovement : MonoBehaviour {
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
//		print (animator.GetCurrentAnimatorStateInfo(0).IsName("LeftDoorMoveDown"));
		if (Input.GetKeyDown ("1")) {
			animator.Play ("LeftDoorMoveUp");
		}

		if (Input.GetKeyDown ("2")) {
			animator.Play ("LeftDoorMoveDown");
		}
	}
}
