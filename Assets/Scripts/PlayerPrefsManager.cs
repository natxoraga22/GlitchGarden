using UnityEngine;
using System.Collections;


public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "MasterVolume";
	const string DIFFICULTY_KEY = "Difficulty";

	const float MIN_MASTER_VOLUME = 0f;
	const float MAX_MASTER_VOLUME = 1f;
	const float DEFAULT_MASTER_VOLUME = 1f;

	const int MIN_DIFFICULTY = 1;
	const int MAX_DIFFICULTY = 3;
	const int DEFAULT_DIFFICULTY = 2;


	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void SetMasterVolume (float newMasterVolume) {
		if (newMasterVolume >= MIN_MASTER_VOLUME && newMasterVolume <= MAX_MASTER_VOLUME) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, newMasterVolume);
		} 
		else {
			Debug.LogError ("Master volume out of range: " + newMasterVolume);
		}
	}

	public static void SetDefaultMasterVolume () {
		SetMasterVolume (DEFAULT_MASTER_VOLUME);
	}


	public static int GetDifficulty () {
		return PlayerPrefs.GetInt (DIFFICULTY_KEY);
	}

	public static void SetDifficulty (int newDifficulty) {
		if (newDifficulty >= MIN_DIFFICULTY && newDifficulty <= MAX_DIFFICULTY) {
			PlayerPrefs.SetInt (DIFFICULTY_KEY, newDifficulty);
		} 
		else {
			Debug.LogError ("Difficulty out of range: " + newDifficulty);
		}
	}

	public static void SetDefaultDifficulty () {
		SetDifficulty (DEFAULT_DIFFICULTY);
	}

}
