using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Boundaries for objects
    private float topBound = -15;
    private float lowerBound = 35;

    // Update is called once per frame
    void Update()
    {
        // Destroys object if out of bounds
        if (transform.position.z < topBound){
            Destroy(gameObject);
        } else if (transform.position.z > lowerBound){
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }

    }
}
