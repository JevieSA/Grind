using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {

	public float fireRate = 1f;
	public GameObject target;
	public Rigidbody blasterBolt;
	public int boltSpeed = 100;

	private bool firing;
	private LookAt lookAt;
	private GameObject gunBarrel;

	IEnumerator Fire() {

		firing = true;

		Rigidbody blasterBoltClone = (Rigidbody)Instantiate (blasterBolt, gunBarrel.transform.position, gunBarrel.transform.rotation);
		blasterBoltClone.velocity = gunBarrel.transform.forward * boltSpeed;

		yield return new WaitForSeconds (fireRate);

		firing = false;

	}

	void Start() {
		lookAt = GetComponent<LookAt> ();
		gunBarrel = GameObject.FindGameObjectWithTag ("GunBarrel");
	}

	// Update is called once per frame
	void Update () {

		if (lookAt.focusedObject != null)
			target = lookAt.focusedObject;
		else
			target = null;

		if(Input.GetButton("Fire1") && !firing){
			StartCoroutine (Fire());
		}
	}
}
