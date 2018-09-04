using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

	private Dictionary<int, int> playerInventory;

	// Use this for initialization
	void Start () {
		LoadInventory ();
	}

	void LoadInventory(){
		playerInventory = new Dictionary<int, int> ();
	}

	public void AddItem(int id, int quantity) {
		if (playerInventory.Count > 0) {
			if (playerInventory.ContainsKey(id))
					playerInventory[id] += quantity;
				else {
					playerInventory.Add (id, quantity);
				}
		} else {
			playerInventory.Add (id, quantity);
		}

		PrintInventory ();
	}

	void PrintInventory() {
		foreach(KeyValuePair<int, int> i in playerInventory){	
			print ("ID: " + i.Key + " :: " + i.Value);
		}
	}
}
