using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterBoltRed : MonoBehaviour {

	public float ammoDamage = 5f;
	public float ammoLifetime = 1f;
	public GameObject hitParticles;

	private ContactPoint contactPoint;

	// Destroy bullet prefab after certain amount of time
	IEnumerator DestroyBulletAfterTime() {
		yield return new WaitForSeconds (ammoLifetime);
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (DestroyBulletAfterTime ());
	}

	// Detect what the bullet overlaps with and does work
	void OnCollisionEnter(Collision other){
		contactPoint = other.contacts[0];

		if (other.gameObject.tag == "Enemy") {
			SpawnHitParticles ();
			EnemyStats enemyStats = other.gameObject.GetComponent<EnemyStats> ();
			enemyStats.TakeDamage (ammoDamage);
			Destroy (gameObject);
		} else if (other.gameObject.tag == "Player") {
			Destroy (gameObject);
		} else {
			SpawnHitParticles ();

			Destroy (gameObject);
		}
	}

	// Spawns hit particle effect
	void SpawnHitParticles(){
		Quaternion rotation = Quaternion.FromToRotation (Vector3.up, contactPoint.normal);
		Instantiate (hitParticles, contactPoint.point, rotation);
	}
}
