using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public GameObject CruiseMissile;

    Rigidbody rb;
    private float speed;
    private float maxSpeed;
    private float minSpeed;
    private float engineOverload = 1;

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
        Instantiate(CruiseMissile, GameObject.Find("Silo1").transform.position, Quaternion.Euler(90,0,0));
    }
}
