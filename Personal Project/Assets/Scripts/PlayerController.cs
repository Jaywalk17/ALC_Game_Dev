using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public string entityTurn;
    public int spaceWidth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if player or enemy turn
        if (entityTurn == "playerTurn"){
            // Check keycode for direction of arrow keys
            // Move one space in direction
        }
    }
}



// Movement will be unlike that in other projects
// Only one entity will move at a time, and only in one direction
// Goes from space to space until an enemy is reached