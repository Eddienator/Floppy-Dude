using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeeHighScore : MonoBehaviour
{
    public TMP_Text highScoreDisplay;
    public int highScore;
    void Start()
    {
        highScore = 0;
    }
    void Update()
    {
        highScoreDisplay.SetText("Highscore:" + highScore.ToString());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "HighScore")
        {
            highScoreDisplay.SetText(AddToHighScore());
        }
        
    }
    string AddToHighScore()
    {
        highScore++;
        return highScore.ToString();
    }
}
