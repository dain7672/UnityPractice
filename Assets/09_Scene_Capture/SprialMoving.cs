using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SprialMoving : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public bool moveUpward = false;
    public float movingSpeed = 0.1f;

    public float relative = 0.5f;
    private Vector3 position;
    private Vector3 vector;


    void Start()
    {
        transform.position = Vector3.Lerp(object1.transform.position, object2.transform.position, 0.5f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.15f, transform.localPosition.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        position = Vector3.Lerp(object1.transform.position, object2.transform.position, 0.5f);
        vector =  object1.transform.position - object2.transform.position;
        transform.RotateAround(position, vector, 4);        
        
        
        // transform.position = Vector3.MoveTowards(object1.transform.position, object2.transform.position, 0.1f);
        
    }
}
