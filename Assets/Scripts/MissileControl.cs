using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileControl : MonoBehaviour {

	void Start () {
        transform.rotation = Quaternion.identity;
        transform.rotation = Quaternion.Euler(90, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= transform.forward * Time.deltaTime * 5;
    }
}
