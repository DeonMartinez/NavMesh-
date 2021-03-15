using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameOver = false;
    public float delay = 1f;

    public GameObject winUI;

    public void CompleteLevel ()
    {
        winUI.SetActive(true);
        Invoke("NextLevel", delay);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Invoke("Restart", delay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
