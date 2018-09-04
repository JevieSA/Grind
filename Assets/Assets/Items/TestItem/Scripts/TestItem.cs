using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class TestItem : MonoBehaviour {

	public int id = 0;
	public string itemName = "Test Item";

	private PlayerInventory playerInventory;

	// Detects collisions and destroys the item if it is the player
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			playerInventory = other.GetComponent<PlayerInventory> ();
			playerInventory.AddItem (id, 1);
			Destroy (gameObject);
		}
	}

}
