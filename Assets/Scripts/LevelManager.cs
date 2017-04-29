using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelDelay = 0f;

	void Start () {
		if (autoLoadNextLevelDelay > 0f) Invoke ("LoadNextLevel", autoLoadNextLevelDelay);
	}

	public void LoadLevel (string levelName) {
		SceneManager.LoadScene (levelName);
	}

	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame () {
		Debug.Log ("QuitGame");
		Application.Quit ();
	}

}
