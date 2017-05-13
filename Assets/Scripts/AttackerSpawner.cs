using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackerSpawner : MonoBehaviour {

	public GameObject[] attackerPrefabs;
	public float[] spawnDelays;

	
	void Update () {
		for (int i = 0; i < attackerPrefabs.Length; i++) {
			if (IsTimeToSpawn (spawnDelays [i])) {
				Spawn (attackerPrefabs[i]);
			}
		}
	}
	
	bool IsTimeToSpawn (float spawnDelay) {
		if (Time.deltaTime > spawnDelay) {
			Debug.LogWarning ("Spawn rate capped by frame rate");
		} 

		float spawnsPerSecond = 1f / spawnDelay;
		float threshold = spawnsPerSecond * Time.deltaTime;
		return Random.value < threshold;
	}

	void Spawn (GameObject attackerPrefab) {
		int spawnPointIndex = Random.Range (0, this.transform.childCount);
		Transform spawnPoint = this.transform.GetChild (spawnPointIndex);
		Instantiate (attackerPrefab, spawnPoint.position, Quaternion.identity, spawnPoint);
	}

}
