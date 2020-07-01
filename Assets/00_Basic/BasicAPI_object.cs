using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAPI_object : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);    
        Instantiate(obj, transform.position, Quaternion.identity);
        Destroy(obj);
        //transform.rotation을 쓰는 거랑, Quarternion.identity를 쓰는 거랑 무엇이 다를까?

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
