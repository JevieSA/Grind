using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public int itemId;
	public string itemName;
	public int itemQuantity;

	public string PrintItem(){
		return "ID: " + itemId + " || Name: " + itemName + " || Quantity: " + itemQuantity;
	}

}
