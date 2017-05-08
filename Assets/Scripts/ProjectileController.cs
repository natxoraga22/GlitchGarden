using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileController : MonoBehaviour {

	public float speed;
	public float damage;


	void Update () {
		this.transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.GetComponent<AttackerController> ()) {
			HealthController targetHealth = collider.gameObject.GetComponent<HealthController> ();
			if (targetHealth) targetHealth.DealDamage (damage);
			Destroy (this.gameObject);
		}
	}

}
