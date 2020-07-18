using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyncScaleFromSlider : MonoBehaviour
{
    public Slider slider;

    // Update is called once per frame
    void Start() {
        PlayerPrefs.SetFloat("scale", 0);
    }
    public void syncSliderValue()
    {
        PlayerPrefs.SetFloat("scale", slider.value);
        Debug.Log("scale: " + slider.value);
    }
}
