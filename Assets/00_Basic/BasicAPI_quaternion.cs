using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAPI_quaternion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(60,60,60), 0.01f);
    }
}
