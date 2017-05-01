using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class MusicManager : MonoBehaviour {

	[System.Serializable]
	public class MusicEntry
	{
		public string key;
		public AudioClip value;
	}

	public MusicEntry[] levelMusic;    

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
		foreach (MusicEntry music in levelMusic) {
			if (music.key == scene.name) {
				audioSource.Stop ();
				audioSource.clip = music.value;
				audioSource.loop = true;
				audioSource.Play ();
			}
		}
	}

}
