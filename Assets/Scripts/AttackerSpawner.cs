using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackerSpawner : MonoBehaviour {

	public GameObject[] attackerPrefabs;
	public float[] spawnDelays;

	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < attackerPrefabs.Length; i++) {
			if (IsTimeToSpawn (spawnDelays [i])) {
				Spawn (attackerPrefabs[i]);
			}
		}
	}
	
	bool IsTimeToSpawn (float spawnDelay) {
		// TODO Implement this
		return true;
	}

	void Spawn (GameObject attackerPrefab) {
		int spawnPointIndex = Random.Range (0, this.transform.childCount);
		Transform spawnPoint = this.transform.GetChild (spawnPointIndex);
		Instantiate (attackerPrefab, spawnPoint.position, Quaternion.identity, spawnPoint);
	}

}
