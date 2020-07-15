using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBySlider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);    
    }

    // Update is called once per frame
    void Update()
    {
        float scale = PlayerPrefs.GetFloat("scale");
        Debug.Log("scale: " + scale);
        transform.localScale = new Vector3(1+scale, 1+scale, 1+scale);
    }
}
