using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	List<ItemBase> itemDB;

	public static ItemManager instance = null;

	// Use this for initialization
	void Awake () {

		// Singleton pattern implementation
		if (instance == null) 
			instance = this;
		 else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

		PopulateItemDB ();
	}
	
	void PopulateItemDB(){
		if (itemDB == null) {
			itemDB = new List<ItemBase> ();
		}

		// TODO: Get items from file

		// Test Item
		itemDB.Add (new ItemBase (0, "Common"));
		itemDB.Add (new ItemBase (1, "Uncommon"));
		itemDB.Add (new ItemBase (2, "Rare"));
		itemDB.Add (new ItemBase (3, "Epic"));

		// ToString ();
	}

	public ItemBase GetItem(int id){
		foreach (ItemBase i in itemDB) {
			if (i.itemId == id) {
				return i;
			}
		}
		return null;
	}

	void ToString(){
		foreach(ItemBase i in itemDB){	
			print ("ID: " + i.itemId + " :: " + i.itemName);
		}
	}
}
