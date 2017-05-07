using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (AttackerController))]
public class LizardController : MonoBehaviour {

	private AttackerController attackerController;


	void Start () {
		attackerController = GetComponent<AttackerController> ();
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.GetComponent<DefenderController> ()) {
			// Attack all defenders!!
			attackerController.StartAttacking (collider.gameObject);
		}
	}

}
