using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackerSpawnPoint : MonoBehaviour {

	void OnDrawGizmos () {
		Gizmos.DrawWireSphere (this.transform.position, 0.2f);
	}

}
