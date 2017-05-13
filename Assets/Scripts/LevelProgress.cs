using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelProgress : MonoBehaviour {

	public float levelDuration = 120f;

	private Slider slider;
	private AudioSource audioSource;
	private GameObject levelCompletedLabel;
	private LevelManager levelManager;

	private bool isEndOfLevel = false;


	void Start () {
		slider = GetComponent<Slider> ();
		audioSource = GetComponent<AudioSource> ();
		levelCompletedLabel = GameObject.Find ("LevelCompletedLabel");
		levelManager = GameObject.FindObjectOfType<LevelManager> ();

		slider.maxValue = levelDuration;
		levelCompletedLabel.SetActive (false);
	}
	
	void Update () {
		slider.value = Time.timeSinceLevelLoad;

		if (!isEndOfLevel && Time.timeSinceLevelLoad >= levelDuration) {
			Win ();
		}
	}

	void Win () {
		isEndOfLevel = true;
		audioSource.Play ();
		levelCompletedLabel.SetActive (true);
		Invoke ("LoadNextLevel", audioSource.clip.length);
	}

	void LoadNextLevel () {
		levelManager.LoadNextLevel ();
	}

}
