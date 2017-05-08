using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DefenderSelectorButton : MonoBehaviour {

	public GameObject defenderPrefab;
	public static GameObject selectedDefender;

	private SpriteRenderer spriteRenderer;
	private DefenderSelectorButton[] buttons;


	void Start () {
		spriteRenderer = GetComponentInChildren<SpriteRenderer> ();
		buttons = GameObject.FindObjectsOfType<DefenderSelectorButton> ();
	}

	void OnMouseDown () {
		// Black out everything
		foreach (DefenderSelectorButton button in buttons) {
			button.GetComponentInChildren<SpriteRenderer> ().color = Color.black;
		}
		// Set the clicked one to white
		spriteRenderer.color = Color.white;
		selectedDefender = defenderPrefab;
	}

}
