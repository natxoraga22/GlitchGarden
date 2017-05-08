using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShooterController : MonoBehaviour {

	public GameObject projectilePrefab;

	private GameObject projectileSpawnPoint;
	private GameObject projectileParent;


	void Start () {
		projectileSpawnPoint = this.transform.FindChild("ProjectileSpawnPoint").gameObject;
		projectileParent = GameObject.Find ("Projectiles");
	}
	
	void FireProjectile () {
		Instantiate (projectilePrefab, projectileSpawnPoint.transform.position, Quaternion.identity, projectileParent.transform);
	}

}
