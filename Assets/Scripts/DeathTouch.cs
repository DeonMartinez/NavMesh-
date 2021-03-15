using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTouch : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            gameManager.EndGame();
        }
    }
}
