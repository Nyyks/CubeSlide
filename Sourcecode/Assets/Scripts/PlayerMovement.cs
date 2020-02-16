using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0 ,0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }

  

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }

        if (Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x > Screen.width / 2)
            {
                rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
            }
            else
            {
                rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
            }
        }


        if (rb.position.y < -1.5f)
        {
            FindObjectOfType<GameManager>().Fail();
        }


    }
}
