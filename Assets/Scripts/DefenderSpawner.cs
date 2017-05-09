using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DefenderSpawner : MonoBehaviour {

	private GameObject defenderParent;


	void Start () {
		defenderParent = GameObject.Find ("Defenders");
		if (!defenderParent) {
			defenderParent = new GameObject ("Defenders");
		}
	}

	void OnMouseDown () {
		Vector3 worldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector2 defenderPosition = new Vector2 (Mathf.Round (worldPosition.x), Mathf.Round (worldPosition.y));

		// Instantiate defender
		Instantiate (DefenderSelectorButton.selectedDefenderPrefab, defenderPosition, Quaternion.identity, defenderParent.transform);
	}

}
