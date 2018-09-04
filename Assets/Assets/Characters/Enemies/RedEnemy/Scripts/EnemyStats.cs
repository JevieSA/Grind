using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

	public float health = 100f;

	public void takeDamage(float damageAmount) {
		health -= damageAmount;

		print (transform + " health: " + health);

		if (isDead())
			die();
	}

	public bool isDead(){
		if(health <= 0)
			return true;

		return false;
	}

	public void die(){
		Destroy (gameObject);
	}
}
