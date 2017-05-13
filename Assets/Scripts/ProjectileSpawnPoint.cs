using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileSpawnPoint : MonoBehaviour {

	void OnDrawGizmos () {
		Gizmos.DrawWireSphere (this.transform.position, 0.075f);
	}

}
