using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score;
    public Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        this.gameObject.SetActive(!Health.dead);

        if (Health.dead)
        {
            return;
        }
        if (score == 10)
        {
            SceneManager.LoadScene("WinScreen");
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        text.text = score.ToString() + "/10";
    }       
}
