using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Dropdown ColorDropdown;
     
    public void SetQuality (int quailtyIndex)
    {
        QualitySettings.SetQualityLevel(quailtyIndex);
    }

    public void SetColor (int index)
    {
        //Debug.Log(ColorDropdown.value);
        PlayerPrefs.SetInt("Color", ColorDropdown.value);
    }

    

}
