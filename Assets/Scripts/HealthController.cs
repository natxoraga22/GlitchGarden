using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthController : MonoBehaviour {

	public float health;


	public void DealDamage (float damage) {
		health -= damage;
		if (health <= 0f) {
			// Optionally trigger an animation (die state)
			Die ();
		}
	}

	void Die() {
		Destroy (this.gameObject);
	}

}
