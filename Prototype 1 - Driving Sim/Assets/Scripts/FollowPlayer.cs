using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,8,-15);

    // Update is called once per frame
    void Update()
    {
        // Makes Camera follow Player position with offset
        transform.position = player.transform.position + offset;
    }
}
