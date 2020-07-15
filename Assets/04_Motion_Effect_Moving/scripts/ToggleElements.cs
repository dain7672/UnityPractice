using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleElements : MonoBehaviour
{
    public Toggle skinToggle;
    public Toggle skeletonToggle;
    public Toggle effectToggle;

    void Start()
    {
        PlayerPrefs.SetInt("isSkinVisible", 1);
        PlayerPrefs.SetInt("isSkeletonVisible", 1);
        PlayerPrefs.SetInt("isEffectVisible", 1);
    }
    public void toggleSkin()
    {
        PlayerPrefs.SetInt("isSkinVisible", skinToggle.isOn ? 1 : 0);
    }

    public void toggleSkeleton()
    {
        PlayerPrefs.SetInt("isSkeletonVisible", skeletonToggle.isOn ? 1 : 0);
    }

    public void toggleEffect()
    {
        PlayerPrefs.SetInt("isEffectVisible", effectToggle.isOn ? 1 : 0);
    }
}
