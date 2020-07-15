using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinVisibleByToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isOn = PlayerPrefs.GetInt("isSkinVisible") == 1;
        GetComponent<SkinnedMeshRenderer>().enabled = isOn;
    }

    // Update is called once per frame
    void Update()
    {
        bool isOn = PlayerPrefs.GetInt("isSkinVisible") == 1;
        GetComponent<SkinnedMeshRenderer>().enabled = isOn;
    }
}
