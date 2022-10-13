using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    //////////////////// SCORE SYSTEM //////////////////////

    public TextMeshProUGUI scoreText;
    // public TextMeshProUGUI hiScoreText;

    public float scoreCount; 
    // public float hiScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;

    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        // if(scoreCount > hiScoreCount)
        // {
        //     hiScoreCount = scoreCount;
        // }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        // hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);
    }
}
