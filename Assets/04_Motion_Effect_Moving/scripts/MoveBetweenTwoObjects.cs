using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetweenTwoObjects : MonoBehaviour
{
    public GameObject obj;
    public GameObject particle2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(obj.transform.position, particle2.transform.position, 0.5f);
    }
}
