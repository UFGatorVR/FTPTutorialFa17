using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // The initial value of variables that are declared public can be edited
    // from the inspector panel of Unity without changing any code.

    // Transform components for the player and camera.
    public Transform playerTransform, cameraTransform;
    // Player movement speed.
    public float speed;
    	
	// Update is one of many "built-in" methods that are automatically called by Unity.
    // Update is called once every frame.
	void Update () {
        // The trigger on a Google Cardboard headset can be detected as a mouse click due to
        // Unity's cross platform behaviors.
        // If the user is pressing the Cardboard trigger...
        if (Input.GetMouseButton(0))
        {
            // Move the player forward in the cameras forward direction.
            playerTransform.position += cameraTransform.forward * speed;
        }
	}
}
