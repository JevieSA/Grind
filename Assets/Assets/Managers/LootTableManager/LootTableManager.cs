using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTableManager : MonoBehaviour {

	public static LootTableManager instance;

	List<LootTable> lootTables;

	void Awake() {
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

		List<int> commonItems = new List<int>();
		List<int> uncommonItems = new List<int>();
		List<int> rareItems = new List<int>();
		List<int> epicItems = new List<int>();

		commonItems.Add(0);
		uncommonItems.Add(1);
		rareItems.Add(2);
		epicItems.Add(3);

		lootTables.Add (new LootTable(0, 10, commonItems, uncommonItems, rareItems, epicItems));
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
