using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item  {

	public int itemId { get; }
	public string itemName { get; }
	public int itemQuantity { get; set; }

	public Item(int id, int quantity){
		itemId = id;
		itemQuantity = quantity;
	}

}
