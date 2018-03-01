using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    public ParticleSystem explosion;

    void Start () {
        Instantiate(explosion, transform.position, Quaternion.identity);

        Collider[] colliders = Physics.OverlapSphere(transform.position, Constants.explosionRadius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(800, transform.position, Constants.explosionRadius, 2.0f);
            }
        }
    }
}
