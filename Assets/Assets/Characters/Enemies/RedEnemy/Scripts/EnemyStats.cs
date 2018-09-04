using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

	public int lootTableId = 0;
	public float health = 100f;
	public GameObject spawnableItemPrefab;

	private LootTable lootTable;

	public void TakeDamage(float damageAmount) {
		health -= damageAmount;

		// print (transform + " health: " + health);

		if (IsDead())
			Die();
	}

	public bool IsDead(){
		if(health <= 0)
			return true;

		return false;
	}

	public void Die(){
		lootTable = GetComponent<LootTable> ();
		List<int> droppedItems = lootTable.GetListOfItemsDropped ();

		foreach (int i in droppedItems) {
			Item item = spawnableItemPrefab.GetComponent<Item> ();
			ItemBase itemTemp = ItemManager.instance.GetItem (i);

			if (item != null && itemTemp != null) {
				item.itemId = itemTemp.itemId;
				item.itemName = itemTemp.itemName;
			}

			Instantiate (spawnableItemPrefab, transform.position, transform.rotation);

			item = null;
			itemTemp = null;
		}

		Destroy (gameObject);
	}
}
