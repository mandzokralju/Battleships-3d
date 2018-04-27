using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ship : MonoBehaviour {

    public GameObject mainCannon;
    public GameObject cruiseMissile;
    public GameObject[] missileSilo;
    
    /// <summary>
    /// Spawns missile in given silo;
    /// </summary>
    /// <param name="missile">Missile to be spawned</param>
    /// <param name="position">Silo to spawn the missile</param>
    protected void LaunchMissile(GameObject missile, Vector3 position)
    {
        Instantiate(missile, position, Quaternion.identity);
    }

    protected void SpawnMissiles(GameObject[] silo, GameObject missile)
    {
        for(int i = 0; i < silo.Length; i++)
        {
            missile.transform.position = silo[i].transform.position;
            
        }
    }
}
