using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int score;

/////////////// COIN SYSTEM //////////////////

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "x" + score.ToString();
        Debug.Log("Coin Collected!");
    }

}