using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour
{
    int score = 0;
    Text scoreDisplay;
    void Start()
    {
        scoreDisplay = GetComponent<Text>();
    }

    void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    public void AddScore()
    {
        score = score + 15;
    }


}
