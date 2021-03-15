using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int lateralSpeed = 2;

    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(lateralSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-lateralSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, lateralSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -lateralSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
