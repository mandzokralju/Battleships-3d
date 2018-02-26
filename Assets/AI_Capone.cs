using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Capone : MonoBehaviour {

	public ParticleSystem explosion;
	public GameObject fractured;

	void Start () {
		Invoke ("Destruction", 3);
	}
	
	void FixedUpdate () {
		
	}

	void Destruction(){
		explosion.transform.SetPositionAndRotation (new Vector3(
			transform.position.x,
			transform.position.y + 2,
			transform.position.z),
			transform.rotation);
		
		explosion.Play;
		Instantiate (fractured, transform.position, transform.rotation);
		Destroy ();
	}
}
