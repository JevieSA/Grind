using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

	private List<Item> playerInventory;

	// Use this for initialization
	void Start () {
		LoadInventory ();
	}

	void LoadInventory(){
		playerInventory = new List<Item> ();
	}

	public void AddItem(int id, int quantity) {
		playerInventory.Add (new Item(id, quantity));
		PrintInventory ();
	}

	void PrintInventory() {

		foreach(Item i in playerInventory){	
			print ("ID: " + i.itemId + " :: " + i.itemQuantity);
		}
	}
}
