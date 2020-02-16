using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollision : MonoBehaviour
{
    public Collider Hitbox;
    public Rigidbody Rigidbody;
    public GameObject[] ItemIcons;

    //Item Section
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlowMo"))
        {
            Slowmo();
        }
        if (other.gameObject.CompareTag("Invincibility"))
        {
            Invincibility();
        }
        if (other.gameObject.CompareTag("Speed"))
        {
            Speed();
        }

    }

    



    //SlowMo Item
    void Slowmo()
    {
        Time.timeScale = 0.65f;
        Invoke("EndSlowmo", 1.5f);
        ItemIcons[0].SetActive(true);
    }
    void EndSlowmo()
    {
        Time.timeScale = 1f;
        ItemIcons[0].SetActive(false);
    }



    //Invincibility Item
    void Invincibility()
    {
        Invoke("EndInvincibility", 2f);
        Rigidbody.useGravity = false;
        Hitbox.enabled = false;
        ItemIcons[1].SetActive(true);
    }
    void EndInvincibility()
    {
        Hitbox.enabled = true;
        Rigidbody.useGravity = true;
        ItemIcons[1].SetActive(false);
    }




    //Speed Pad
    void Speed()
    {
        Time.timeScale = 1.65f;
        Invoke("EndSpeed", 1.2f);
        ItemIcons[0].SetActive(false);
    }

  void EndSpeed()
    {
        Time.timeScale = 1.0f;
    }

}

