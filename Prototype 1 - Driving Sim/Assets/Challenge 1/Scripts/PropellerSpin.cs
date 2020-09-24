using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour    
{
    public float propellerSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        // Makes propeller spin perpendicular to plane flying direction
        transform.Rotate(Vector3.forward * propellerSpeed);
    }
}
