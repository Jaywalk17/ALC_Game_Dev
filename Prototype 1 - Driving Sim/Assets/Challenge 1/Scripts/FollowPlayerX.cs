using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(-13, 4, 0);


    // Update is called once per frame
    void Update()
    {
        // Makes camera follow plane
        transform.position = plane.transform.position + offset;
    }
}
