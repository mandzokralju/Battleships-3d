using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public GameObject CruiseMissile;
    public GameObject CannonX;
    public GameObject CannonY;

    Rigidbody rb;
    private float speed;
    private float maxSpeed;
    private float minSpeed;
    private float engineOverload = 1;
    private float horizontal = 0.0f;
    private float vertical = 0.0f;

    void Start () {
        rb = GetComponent<Rigidbody>();
        speed = 0;
        maxSpeed = 4;
        minSpeed = -2;
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
            engineOverload = 1.25f;
        rb.velocity = transform.forward * speed * engineOverload;
        engineOverload = 1;

        /*****Cannon control*****/
        horizontal += Constants.speedH * Input.GetAxis("Mouse X");
        vertical -= Constants.speedV * Input.GetAxis("Mouse Y");

        CannonX.transform.eulerAngles = new Vector3(-90, 0, horizontal + 180);
        CannonY.transform.eulerAngles = new Vector3(0, vertical, 0);
        /************************/

        if (Input.GetKeyDown(KeyCode.W) && speed <= maxSpeed)
            speed += 1;
        if (Input.GetKeyDown(KeyCode.S) && speed >= minSpeed)
            speed -= 1;
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down * Time.deltaTime * 10);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * Time.deltaTime * 10);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            LaunchMissile();
        }
    }

    void LaunchMissile()
    {
        Instantiate(CruiseMissile, GameObject.Find("Silo1").transform.position, Quaternion.Euler(0,0,0));
    }
}
