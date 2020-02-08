using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void SetQuality (int quailtyIndex)
    {
        QualitySettings.SetQualityLevel(quailtyIndex);
    }
}
