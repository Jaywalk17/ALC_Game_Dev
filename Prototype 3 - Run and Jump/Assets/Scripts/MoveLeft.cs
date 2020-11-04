using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;

    // Update is called once per frame
    void Update()
    {
        // Moves GameObject left at a set speed
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
