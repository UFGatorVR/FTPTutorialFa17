using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pickup item spawn.
public class ItemSpawn : MonoBehaviour {
    // The GameObject that will be spawned (the pickup).
    public GameObject spawnObject;
    // How much time should pass before the pickup is spawned again.
    public float spawnInterval;

    // The amount of time that has passed since the last pickup was spawned.
    // Since the spawner will have never spawned a pickup before at the start,
    // we can initialize this to a large value so that it will spawn a pickup
    // on the 1st update.
    float timeSinceSpawn = float.MaxValue;
	
	void Update () {
        // If enough time has passed since the last spawn...
        if (timeSinceSpawn > spawnInterval)
        {
            // Spawn a new pickup.
            Spawn();
            // Reset time since spawn.
            timeSinceSpawn = 0;
        }
        // If we need to wait longer before spawning, add the amount of time for
        // this frame to the elapsed time.
        else
        {
            timeSinceSpawn += Time.deltaTime;
        }
	}

    // Spawn the item.
    void Spawn(){
        // Use instantiate to create a new copy of the given GameObject.
        GameObject temp = Instantiate(spawnObject);
        // Make sure the position of the new GameObject is set to the position of the spawner
        // (because that's where we want them to come from).
        temp.transform.position = transform.position;
        // Point the spawned items in random directions.
        temp.transform.forward = Random.onUnitSphere;
    }
}
