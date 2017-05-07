using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderController : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log (this.name + " collision with " + collider.gameObject.name);
	}

}
