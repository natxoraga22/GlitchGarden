using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;

	private LevelManager levelManager;
	private MusicManager musicManager;


	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		musicManager = GameObject.FindObjectOfType<MusicManager> ();

		SetSliders ();
	}

	void SetSliders () {
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}

	void Update () {
		if (musicManager) musicManager.SetVolume (volumeSlider.value);
	}

	public void SetDefaults () {
		PlayerPrefsManager.SetDefaultMasterVolume ();
		PlayerPrefsManager.SetDefaultDifficulty ();
		SetSliders ();
	}

	public void SaveAndExit () {
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty ((int)difficultySlider.value);
		musicManager.SetVolume (volumeSlider.value);
		levelManager.LoadLevel ("Start");
	}

}
