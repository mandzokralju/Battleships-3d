using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public Transform lookat;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    private void start()
    {
        transform.position = GameObject.Find("CameraPoint").transform.position;
    }

    private void Update()
    {
        transform.position = GameObject.Find("CameraPoint").transform.position;

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            GetComponent<Camera>().fieldOfView--;
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            GetComponent<Camera>().fieldOfView++;
    }
}
