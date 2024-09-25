using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMPro.TMP_Text Score;
    public static int currentScore = 0;
    private int highScore = 0;
    public string format = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.SetText(string.Format(format, currentScore, highScore));
    }
}
