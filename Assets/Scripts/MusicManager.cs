using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusic;

	private AudioSource audioSource;


	void Awake () {
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	private void OnEnable () {
		SceneManager.sceneLoaded += OnSceneLoaded; // subscribe
	}

	private void OnDisable () {
		SceneManager.sceneLoaded -= OnSceneLoaded; //unsubscribe
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) {
		audioSource.Stop ();
		if (levelMusic [scene.buildIndex]) {
			audioSource.clip = levelMusic [scene.buildIndex];
			audioSource.loop = true;
			audioSource.Play ();
		}
	}

}
