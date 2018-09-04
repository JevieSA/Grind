using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTable : MonoBehaviour{

	public int lootTableId = 0;
	public List<int> uncommonItems;
	public List<int> commonItems;
	public List<int> rareItems;
	public List<int> epicItems;
	public int itemsToDrop = 0;

	List<int> listOfItemsDropped;


	void Start(){
		commonItems = new List<int>();
		uncommonItems = new List<int>();
		rareItems = new List<int>();
		epicItems = new List<int>();

		commonItems.Add(0);
		uncommonItems.Add(1);
		rareItems.Add(2);
		epicItems.Add(3);
	}

	public List<int> GetListOfItemsDropped(){
		listOfItemsDropped = new List<int> ();

		if (itemsToDrop > 0) {
			for (int i = 0; i < itemsToDrop; i++) {
				int randomNumber = Random.Range (0, 900);

				print ("Random number: " + randomNumber);

				if (randomNumber <= 500 && randomNumber >= 0) {
					listOfItemsDropped.Add(commonItems[0]);
				} else if (randomNumber <= 700 && randomNumber >= 501) {
					listOfItemsDropped.Add(uncommonItems[0]);
				} else if (randomNumber <= 800 && randomNumber >= 701) {
					listOfItemsDropped.Add(rareItems[0]);
				} else if (randomNumber <= 850 && randomNumber >= 801) {
					listOfItemsDropped.Add(epicItems[0]);
				} else if (randomNumber <= 900 && randomNumber >= 851) {
				}
			}
		}
		return listOfItemsDropped;
	}

	public string PrintLootTable(){
		return "ID: " + lootTableId + " || Number of Items to Drop: " + itemsToDrop + " || Uncommon Items size: " + uncommonItems.Count + " || Common Items size: " + commonItems.Count +
		" || Rare Items size: " + rareItems.Count + " || Epic Items size: " + epicItems.Count;
	}
}
