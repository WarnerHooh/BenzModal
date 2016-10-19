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
//		print (animator.GetCurrentAnimatorStateInfo(0).IsName("RightDoorKeepDown"));
		if (Input.GetKeyDown ("1")) {
			if (animator.GetCurrentAnimatorStateInfo (0).IsName ("LeftDoorKeepDown")) {
				animator.Play ("LeftDoorMoveUp");
			}

			if (animator.GetCurrentAnimatorStateInfo (0).IsName ("RightDoorKeepDown")) {
				animator.Play ("RightDoorMoveUp");
			}
		}

		if (Input.GetKeyDown ("2")) {
			if (animator.GetCurrentAnimatorStateInfo (0).IsName ("LeftDoorKeepUp")) {
				animator.Play ("LeftDoorMoveDown");
			}
			if (animator.GetCurrentAnimatorStateInfo (0).IsName ("RightDoorKeepUp")) {
				animator.Play ("RightDoorMoveDown");
			}
		}
	}
}
