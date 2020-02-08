using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableItems : MonoBehaviour
{

    public MeshRenderer[] meshRenderer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            meshRenderer[0].enabled = false;
            meshRenderer[1].enabled = false;
            meshRenderer[2].enabled = false;
            meshRenderer[3].enabled = false;
            meshRenderer[4].enabled = false;
            meshRenderer[5].enabled = false;
            meshRenderer[6].enabled = false;
            meshRenderer[7].enabled = false;
            meshRenderer[8].enabled = false;
            meshRenderer[9].enabled = false;
            meshRenderer[10].enabled = false;
        }
    }
}
