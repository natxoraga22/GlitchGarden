using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (AttackerController))]
public class FoxController : MonoBehaviour {

	private Animator animator;
	private AttackerController attackerController;


	void Start () {
		animator = GetComponent<Animator> ();	
		attackerController = GetComponent<AttackerController> ();
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.GetComponent<DefenderController> ()) {
			// Gravestone!!
			if (collider.gameObject.GetComponent<GravestoneController> ()) {
				animator.SetTrigger ("jumpTrigger");
			}
			// Other defenders!!
			else {
				attackerController.StartAttacking (collider.gameObject);
			}
		}
	}

}
