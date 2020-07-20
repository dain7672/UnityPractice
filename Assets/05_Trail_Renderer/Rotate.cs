using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RotateInPlace : MonoBehaviour
{
    public bool moveUpward = false;
    public float movingSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0,0,0), Vector3.up, 10);
        if (transform.position.y >= 10) {
            moveUpward = false;
        } else if (transform.position.y <= 0) {
            moveUpward = true;
        }
        transform.position = new Vector3(transform.position.x, transform.position.y + movingSpeed * Time.deltaTime * (-1 + 2 * Convert.ToInt16(moveUpward)), transform.position.z);
    }
}
