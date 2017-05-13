using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour {

	private Text starsText;

	private int amountStars = 500;


	void Start () {
		starsText = GetComponent<Text> ();
		UpdateStarsText ();
	}
	
	public void AddStars (int amount) {
		amountStars += amount;
		UpdateStarsText ();
	}

	public bool UseStars (int amount) {
		if (amount > amountStars) return false;
		amountStars -= amount;		
		UpdateStarsText ();
		return true;
	}

	private void UpdateStarsText () {
		starsText.text = amountStars.ToString();
	}

}
