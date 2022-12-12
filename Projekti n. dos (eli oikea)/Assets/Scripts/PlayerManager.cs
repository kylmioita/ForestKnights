using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject gameOverScreen;


    public void Awake()
    {
    }

    void Update()
    {
        if (Health.dead == true)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("AI");
        gameOverScreen.SetActive(false);
        Health.dead = false;
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
        gameOverScreen.SetActive(false);
        Health.dead = false;
    }
}
