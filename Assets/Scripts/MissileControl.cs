using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileControl : MonoBehaviour {

	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * Time.deltaTime * 5;
    }
}
