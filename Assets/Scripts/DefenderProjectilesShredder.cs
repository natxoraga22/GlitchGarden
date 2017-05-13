using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DefenderProjectilesShredder : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.GetComponent<ProjectileController> ()) {
			Destroy (collider.gameObject);
		}
	}

}
