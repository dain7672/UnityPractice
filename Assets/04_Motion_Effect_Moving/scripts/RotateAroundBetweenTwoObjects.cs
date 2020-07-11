using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundBetweenTwoObjects : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    private Vector3 position;
    private Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.Lerp(object1.transform.position, object2.transform.position, 0.5f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.2f, transform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        position = Vector3.Lerp(object1.transform.position, object2.transform.position, 0.5f);
        vector =  object1.transform.position - object2.transform.position;

        Debug.Log(vector);
        transform.RotateAround(position, vector, 4);

    }
}
