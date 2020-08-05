using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnlyWhenPositiveZ : MonoBehaviour
{
    private LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.forceRenderingOff = transform.position.z < 0;
    }
}
