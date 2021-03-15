using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider trigger)
    {
        Debug.Log("ftyfytfyf");
        if (trigger.tag == "Player")
        {
            Debug.Log("player");
            gameManager.CompleteLevel();
        }
    }
}
