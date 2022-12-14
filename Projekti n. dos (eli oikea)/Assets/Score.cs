using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
        text.text = score.ToString() + "/10";
    }       
}
