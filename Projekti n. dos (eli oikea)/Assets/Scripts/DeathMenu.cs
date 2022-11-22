using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("AI");

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
