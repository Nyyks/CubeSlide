using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;




    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Fail();
        } 
    }



    //Item Section
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlowMo"))
        {
            Slowmo();
        }
    }


    void Slowmo()
    {
        Time.timeScale = 0.7f;
        Invoke("EndSlowmo", 1.2f);
    }
    void EndSlowmo()
    {
        Time.timeScale = 1f;
    }
}
