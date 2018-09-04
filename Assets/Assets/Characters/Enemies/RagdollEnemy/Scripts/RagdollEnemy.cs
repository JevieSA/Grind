using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class RagdollEnemy : MonoBehaviour {

	Rigidbody rigidBody;

	void setKinematic(bool isKinematic){
		Rigidbody[] bodies = GetComponentsInChildren<Rigidbody> ();

		foreach (Rigidbody rb in bodies)
			rb.isKinematic = isKinematic;
	}

	// Use this for initialization
	void Start () { 
		setKinematic (true);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("i"))
			setKinematic(false);
	}
}
