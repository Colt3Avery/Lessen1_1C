using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 Offset = new Vector3(0, 7, -10);
    // the private is to set up where the camera is offset from the gameobject(the vehicle)


    void Start()
    {
        
    }

    void Update()
    {
        // the transform is the object that it's attached to (the camera) ((called scoping))
        transform.position = player.transform.position + Offset;
    }
}
