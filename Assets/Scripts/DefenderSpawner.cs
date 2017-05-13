using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DefenderSpawner : MonoBehaviour {

	private StarsDisplay starsDisplay;
	private GameObject defenderParent;


	void Start () {
		starsDisplay = GameObject.FindObjectOfType<StarsDisplay> ();
		defenderParent = GameObject.Find ("Defenders");
		if (!defenderParent) {
			defenderParent = new GameObject ("Defenders");
		}
	}

	void OnMouseDown () {
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector2 defenderPosition = new Vector2 (Mathf.Round (mouseWorldPosition.x), Mathf.Round (mouseWorldPosition.y));

		// Instantiate defender if enough stars
		GameObject defenderPrefab = DefenderSelectorButton.selectedDefenderPrefab;
		if (starsDisplay.UseStars (defenderPrefab.GetComponent<DefenderController> ().starCost)) {
			Instantiate (defenderPrefab, defenderPosition, Quaternion.identity, defenderParent.transform);
		}
	}

}
