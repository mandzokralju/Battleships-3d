using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float horizontal = 180.0f;
    private float vertical = 0.0f;

    private void Update()
    {
        horizontal += speedH * Input.GetAxis("Mouse X");
        vertical -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(vertical, horizontal, 0.0f);

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            GetComponent<Camera>().fieldOfView--;
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            GetComponent<Camera>().fieldOfView++;
    }
}
