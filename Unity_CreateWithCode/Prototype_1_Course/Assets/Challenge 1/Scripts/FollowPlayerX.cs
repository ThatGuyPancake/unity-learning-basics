﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 3, -9);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        
    }
}
