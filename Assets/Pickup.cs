using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pickup item.
public class Pickup : MonoBehaviour {
    // Speed at which the pickup will drift.
    public float speed;

    // Start is a built-in method that is called once before the the first frame.
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

    // OnCollision enter is a built-in method that is called when the object this
    // script is attached to begins colliding with something.
    // In order to register a collision, both colliding objects must have colliders
    // and rigidbodies.
    void OnCollisionEnter(Collision collision){
        // If the player collided with this pickup, destroy the pickup.
        if (collision.gameObject.tag == "Player")
        {
            // "gameobject" get the GameObject this script is attached to.
            // By using the optional 2nd parameter of Destroy(), we can specify a delay time before
            // the object is actually destroyed.
            Destroy(gameObject, 0.5f);
        }
    }

}
