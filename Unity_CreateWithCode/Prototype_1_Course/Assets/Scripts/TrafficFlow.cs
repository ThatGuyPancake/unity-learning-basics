using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficFlow : MonoBehaviour
{
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * (Time.deltaTime * speed));
    }
}
