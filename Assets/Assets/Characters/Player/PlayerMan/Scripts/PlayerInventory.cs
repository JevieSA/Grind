using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

	private List<ItemBase> playerInventory;

	// Use this for initialization
	void Start () {
		LoadInventory ();
	}

	void LoadInventory(){
		playerInventory = new List<ItemBase> ();
	}

	public void AddItem(int id, int quantity) {
		if (playerInventory.Count > 0) {
			foreach (ItemBase i in playerInventory) {
				if (i.itemId == id)
					i.itemQuantity += quantity;
				else
					playerInventory.Add (new ItemBase (id, quantity));
			}
		} else
			playerInventory.Add (new ItemBase (id, quantity));

		PrintInventory ();
	}

	void PrintInventory() {
		foreach(ItemBase i in playerInventory){	
			print ("ID: " + i.itemId + " :: " + i.itemQuantity);
		}
	}
}
