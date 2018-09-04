using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class TestItem : MonoBehaviour {

	private int id = 0;
	private PlayerInventory playerInventory;
	private Item item;

	void Awake(){
		item = GetComponent<Item> ();

		id = item.itemId;

		ItemBase tempItem = ItemManager.instance.GetItem (id);

		if (tempItem != null) {
			item.itemId = tempItem.itemId;
		}
	}

	// Detects collisions and destroys the item if it is the player
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {			
			playerInventory = other.GetComponent<PlayerInventory> ();
			playerInventory.AddItem (id, 1);
			Destroy (gameObject);
		}
	}

}
