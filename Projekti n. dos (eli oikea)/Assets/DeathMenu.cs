using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void ReplayLevel()
    {
        Health.dead = false;
        SceneManager.LoadScene("AI");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
        Health.dead = false;
    }
}
