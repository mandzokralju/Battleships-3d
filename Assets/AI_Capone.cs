using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Capone : MonoBehaviour {

	public ParticleSystem explosion;
	public GameObject fractured;

	void Start () {
		Invoke ("Destruction", 2);
	}
	
	void FixedUpdate () {
		
	}

	void Destruction(){
		Vector3 explosionPoz = transform.position;
		explosion.transform.position = explosionPoz;
		explosion.Stop ();
		explosion.Play ();
		Collider[] colliders = Physics.OverlapSphere (explosionPoz, Constants.explosionRadius);

		foreach (Collider hit in colliders) {
			Rigidbody rb = hit.GetComponent<Rigidbody> ();
			if (rb != null) {
				rb.AddExplosionForce (20, explosionPoz, Constants.explosionRadius, 3.0f);
			}
		}
	}
}
