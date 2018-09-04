using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTable {

	public int lootTableId = 0;

	List<int> listOfItemsDropped;
	int itemsToDrop = 0;
	List<int> uncommonItems = new List<int>();
	List<int> commonItems = new List<int>();
	List<int> rareItems = new List<int>();
	List<int> epicItems = new List<int>();

	public LootTable(int id, int numItemsToDrop, List<int> common, List<int> uncommon, List<int> rare, List<int> epic){
		lootTableId = id;
		itemsToDrop = numItemsToDrop;
		commonItems = common;
		uncommonItems = uncommon;
		rareItems = rare;
		epicItems = epic;
	}

	public List<int> GetListOfItemsDropped(){
		listOfItemsDropped = new List<int> ();

		if (itemsToDrop > 0) {
			for (int i = 0; i < itemsToDrop; i++) {
				int randomNumber = Random.Range (0, 900);

				if (randomNumber <= 500 && randomNumber >= 0) {
					listOfItemsDropped.Add(commonItems.IndexOf(0));
				} else if (randomNumber <= 700 && randomNumber >= 501) {
					listOfItemsDropped.Add(uncommonItems.IndexOf(0));
				} else if (randomNumber <= 800 && randomNumber >= 701) {
					listOfItemsDropped.Add(rareItems.IndexOf(0));
				} else if (randomNumber <= 850 && randomNumber >= 801) {
					listOfItemsDropped.Add(epicItems.IndexOf(0));
				} else if (randomNumber <= 900 && randomNumber >= 851) {
				}
			}
		}
		return listOfItemsDropped;
	}
}
