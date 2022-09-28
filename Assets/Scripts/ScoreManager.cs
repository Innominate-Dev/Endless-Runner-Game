using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TextMeshProUGUI text;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        Debug.Log("Script is running!");
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "x" + score.ToString();
        Debug.Log("Coin Collected!");
    }
}