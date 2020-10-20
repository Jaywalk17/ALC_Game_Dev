using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Destroys animal when colliding with food
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

}
