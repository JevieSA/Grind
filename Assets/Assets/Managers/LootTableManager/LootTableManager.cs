using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTableManager : MonoBehaviour {

	public static LootTableManager instance;

	List<LootTable> lootTables;

	void Start() {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

		PopulateLootTableManager ();
	}

	void PopulateLootTableManager(){
		lootTables = new List<LootTable> ();

		// TODO: Get loot tables from file

		// lootTables.Add (lT);
	}

	public List<int> GetDroppedItems(int lootTableId){
		List<int> droppedItems = new List<int> ();

		foreach (LootTable lT in lootTables) {
			if (lT.lootTableId == lootTableId) {
				droppedItems = lT.GetListOfItemsDropped ();
			}
		}

		return droppedItems;
	}
}
