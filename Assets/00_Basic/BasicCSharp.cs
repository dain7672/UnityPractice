using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCSharp : MonoBehaviour
{
    int number;
    float number02;
    string myName;
    bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        number = 10;
        Debug.Log(number);
        number02 = 0.5f; //float 는 f 넣어주어야 함.
        myName = "DainKim"; //문자열은 쌍따옴표
        isOn = true;
        Debug.Log(number02 + myName + isOn);

        if (number == 10)
        {
            Debug.Log("number = 10");
        }
        else if (number > 10)
        {
            Debug.Log("number > 10");
        }
        else
        {
            Debug.Log("number < 10");
        }
        for (int i=0; i<10; i++)
        {
            Debug.Log(i);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
