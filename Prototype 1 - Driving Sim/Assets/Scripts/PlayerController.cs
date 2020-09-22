using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 30;
    private float turnSpeed = 50;
    
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Moves vehicle forward based on VerticalInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        // Moves vehicle left and right based on HorizontalInput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
