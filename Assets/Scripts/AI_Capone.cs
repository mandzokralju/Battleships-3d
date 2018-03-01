using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Capone : MonoBehaviour {
	
	public GameObject fractured;
    
    private Vector3 shipPoz;
    private Quaternion shipRot;

	void Start () {
		Invoke ("Destruction", 2);
	}
	
	void FixedUpdate () {
		
	}

	void Destruction(){
        shipPoz = transform.position;
        shipRot = transform.rotation;

        Destroy(gameObject);
        Instantiate(fractured, shipPoz, shipRot);	
	}
}
