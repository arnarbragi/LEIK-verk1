using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Þetta er að nota componentið Rigidbody og er kallað rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Við notum "Fixed"Update því að við erum að fikta í physics
    void FixedUpdate()
    {
        //bæti við krafti áfram
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
