using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController playerControllerScript;

    private float leftBound = -15;

    private void Start() 
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Moves GameObject left at a set speed
        if(playerControllerScript.gameOver == false){
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        // Destroys obstacle prefab off screen
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }

    }
}
