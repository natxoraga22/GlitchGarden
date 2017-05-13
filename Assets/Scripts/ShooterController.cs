using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShooterController : MonoBehaviour {

	public GameObject projectilePrefab;

	private Animator animator;
	private GameObject projectileSpawnPoint;

	private GameObject attackerSpawnPoint;
	private GameObject projectileParent;


	void Start () {
		animator = GetComponent<Animator> ();
		projectileSpawnPoint = this.transform.FindChild("ProjectileSpawnPoint").gameObject;

		// Attacker spawn point for this shooter's lane
		GameObject attackerSpawner = GameObject.Find ("AttackerSpawner");
		foreach (Transform spawnPoint in attackerSpawner.transform) {
			if (spawnPoint.position.y == this.transform.position.y) {
				attackerSpawnPoint = spawnPoint.gameObject;
				break;
			}
		}

		// Projectiles parent
		projectileParent = GameObject.Find ("Projectiles");
		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
	}

	void Update () {
		animator.SetBool ("isAttacking", IsAttackerAheadInLane());
	}

	bool IsAttackerAheadInLane () {
		foreach (Transform attacker in attackerSpawnPoint.transform) {
			if (attacker.position.x > this.transform.position.x) return true;
		}
		return false;
	}
	
	void FireProjectile () {
		Instantiate (projectilePrefab, projectileSpawnPoint.transform.position, Quaternion.identity, projectileParent.transform);
	}

}
