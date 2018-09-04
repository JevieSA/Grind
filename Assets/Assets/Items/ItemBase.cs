using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase  {

	public int itemId;
	public string itemName;
	public int itemQuantity;

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

	public string PrintItem(){
		return "ID: " + itemId + " || Name: " + itemName + " || Quantity: " + itemQuantity;
	}
}
