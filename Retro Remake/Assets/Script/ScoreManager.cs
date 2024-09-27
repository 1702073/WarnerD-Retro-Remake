using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMPro.TMP_Text Score;
    public static int currentScore = 0;
    public static int versusScore = 0;
    public string format = "";

    // Update is called once per frame
    void Update()
    {
        Score.SetText(string.Format(format, currentScore, PlayerPrefs.GetInt("highScore"), versusScore));
    }
}
