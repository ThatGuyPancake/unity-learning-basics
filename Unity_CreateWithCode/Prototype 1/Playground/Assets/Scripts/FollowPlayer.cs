﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Offset the camera to the player by adding the player's position
        transform.position = player.transform.position + offset;
    }
}
