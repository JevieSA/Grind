using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWomanAnimation : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("f")) {
			animator.SetTrigger ("Walk");
			transform.Translate (0, 0, 1 * Time.deltaTime);
		} else {
			animator.SetTrigger ("Idle");
		}
	}
}
