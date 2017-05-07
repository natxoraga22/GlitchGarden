using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileController : MonoBehaviour {

	public float speed;
	public float damage;


	void Update () {
		this.transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
}
