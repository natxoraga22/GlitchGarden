using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (Rigidbody2D))]
public class AttackerController : MonoBehaviour {

	private Animator animator;

	private float currentSpeed;
	private GameObject currentTarget;


	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {
		if (!currentTarget) {
			animator.SetBool ("isAttacking", false);
		}
		this.transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log (this.name + " collision with " + collider.gameObject.name);
	}

	void SetCurrentSpeed (float newCurrentSpeed) {
		currentSpeed = newCurrentSpeed;
	}

	// Puts this attacker into attacking animation
	public void StartAttacking (GameObject defender) {
		currentTarget = defender;
		animator.SetBool ("isAttacking", true);
	}

	// Called from the animator, deals damage
	void StrikeCurrentTarget (float damage) {
		if (currentTarget) {
			currentTarget.GetComponent<HealthController> ().DealDamage (damage);
		}
	}

}
