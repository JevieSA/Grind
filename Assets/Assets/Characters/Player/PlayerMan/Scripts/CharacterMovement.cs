using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	public Rigidbody rigidBody;

	public int moveSpeed = 50;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;

		rigidBody.AddForce (v, h, 0, ForceMode.VelocityChange);

	}
}
