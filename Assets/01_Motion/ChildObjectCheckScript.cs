using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObjectCheckScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            //child is your child transform
            Debug.Log(child);
        }
        Debug.Log(transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).gameObject);
        transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).gameObject.transform.localPosition = new Vector3(3,3,3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
