using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public Material[] Color;
    private int ChosenColor;
    public Renderer ColorRenderer;


    private void Awake()
    {
        ChosenColor = PlayerPrefs.GetInt("Color");
    }

    void Start()
    {

        //Debug.Log("The chosen Color is"Color[ChosenColor].name);

        ColorRenderer.enabled = true;
        ColorRenderer.sharedMaterial = Color[ChosenColor];
    }
    
}
