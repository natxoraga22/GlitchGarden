using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour {

	public int initialAmountStars = 500;

	private Text starsText;

	private int amountStars;


	void Start () {
		starsText = GetComponent<Text> ();
		amountStars = initialAmountStars;
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
