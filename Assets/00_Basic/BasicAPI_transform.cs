using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAPI_transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //   transform.position = new Vector3(10, 10, 10);
        //   transform.rotation = Quaternion.Euler(30, 60, 90);
        //   transform.localScale = new Vector3(3,3,3);

          Debug.Log("This is Start!!!");
          Debug.Log("x = " + transform.position.x);
          Debug.Log("y = " + transform.position.y);
          Debug.Log("z = " + transform.position.z);

          Debug.Log("x = " + transform.localPosition.x);
          Debug.Log("z = " + transform.localPosition.z);
          Debug.Log("y = " + transform.localPosition.y);

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward*0.01f);
        // transform.RotateAround(Vector3.up, 90); //deprecated 회전
        
        // transform.Rotate(Vector3.up, 10); // 10도 회전
        transform.RotateAround(new Vector3(0,0,0), Vector3.up, 1); //A좌표를 지나는 B각도를 기준으로 해서 C각도 회전
        // 공전은 이해가 되는데, 자전하는 이유는?
        Debug.Log("rotating...");
        
    }
}
