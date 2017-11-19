using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {

    public float UpwardForce = 11.72f;
    float depth;

    void FixedUpdate() {
        if(transform.position.y < 4.5) {
            depth = transform.position.y / 4.5f;
            GetComponent<Rigidbody>().drag = 10 * depth;
            Debug.Log("Depth coeficient " + depth);
            Vector3 force = transform.up * UpwardForce;
            GetComponent<Rigidbody>().AddRelativeForce(force, ForceMode.Acceleration);
        }
        else
            GetComponent<Rigidbody>().drag = 0.05f;
    }
}﻿
