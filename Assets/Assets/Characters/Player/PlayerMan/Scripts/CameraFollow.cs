using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	public GameObject cameraArm;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		cameraArm = GameObject.FindGameObjectWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 cameraArmLocationWithoutY = new Vector3 (player.transform.position.x, 0, player.transform.position.z);

		cameraArm.transform.position = cameraArmLocationWithoutY;
	}
}
