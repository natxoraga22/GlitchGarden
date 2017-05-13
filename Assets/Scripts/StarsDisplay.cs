using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour {

	private Text starsText;

	private int amountStars = 100;


	void Start () {
		starsText = GetComponent<Text> ();
		UpdateStarsText ();
	}
	
	public void AddStars (int amount) {
		amountStars += amount;
		UpdateStarsText ();
	}

	public void UseStars (int amount) {
		amountStars -= amount;		
		UpdateStarsText ();
	}

	private void UpdateStarsText () {
		starsText.text = amountStars.ToString();
	}

}
