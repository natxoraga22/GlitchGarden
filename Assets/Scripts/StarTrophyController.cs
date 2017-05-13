using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StarTrophyController : MonoBehaviour {

	private StarsDisplay starsDisplay;


	void Start () {
		starsDisplay = GameObject.FindObjectOfType<StarsDisplay> ();
	}

	void AddStars (int amount) {
		starsDisplay.AddStars (amount);
	}

}
