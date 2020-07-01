using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAPI_vector3 : MonoBehaviour
{
    bool finishedMovingForward = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.x > 9) {
            finishedMovingForward = true;
        }
        if (!finishedMovingForward) {
            transform.position = Vector3.Lerp(transform.position, new Vector3(10, 10, 10), 0.1f);
            // 두 지점 사이 거리 * 0.1만큼 이동한다. -> 1 + 0.9 + 0.81 + ... 으로 이어진다.
            // 첫번쨰, 두번째 인자 둘 다 상수라면, 1프레임만에 이동이 끝나버릴 것이다.
            // if문이 없으면 끝없이 이동할 것이다.
        } else {
             transform.position = Vector3.MoveTowards(transform.position, new Vector3(-10, -10, -10), 0.1f);
        }
    }
}
