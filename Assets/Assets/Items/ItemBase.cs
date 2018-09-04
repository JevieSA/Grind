using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase  {

	public int itemId { get; set; }
	public string itemName { get; set; }
	public int itemQuantity { get; set; }

	public ItemBase(int id, int quantity){
		itemId = id;
		itemName = "No Name Brand";
		itemQuantity = quantity;
	}

	public ItemBase(int id, string name){
		itemId = id;
		itemName = name;
		itemQuantity = 0;
	}
}
