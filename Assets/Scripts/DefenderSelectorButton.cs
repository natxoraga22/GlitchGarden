using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DefenderSelectorButton : MonoBehaviour {

	public GameObject defenderPrefab;
	public static GameObject selectedDefenderPrefab;

	private SpriteRenderer spriteRenderer;
	private DefenderSelectorButton[] buttons;


	void Start () {
		spriteRenderer = GetComponentInChildren<SpriteRenderer> ();
		buttons = GameObject.FindObjectsOfType<DefenderSelectorButton> ();
		SetStarCostText ();
	}

	void SetStarCostText () {
		this.transform.GetComponentInChildren<Text> ().text = defenderPrefab.GetComponent<DefenderController> ().starCost.ToString ();
	}

	void OnMouseDown () {
		// Black out everything
		foreach (DefenderSelectorButton button in buttons) {
			button.GetComponentInChildren<SpriteRenderer> ().color = Color.black;
		}
		// Set the clicked one to white
		spriteRenderer.color = Color.white;
		selectedDefenderPrefab = defenderPrefab;
	}

}
