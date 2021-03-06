﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GravestoneController : MonoBehaviour {

	private Animator animator;


	void Start () {
		animator = GetComponent<Animator> ();
	}

	void OnTriggerStay2D (Collider2D collider) {
		if (collider.gameObject.GetComponent<AttackerController> ()) {
			animator.SetTrigger ("underAttackTrigger");
		}
	}

}
