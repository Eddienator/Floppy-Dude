using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeeHighScore : MonoBehaviour
{
    public TMP_Text highScoreDisplay;
    public int score;
    public int highscore = 0;
    void Start()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", highscore);
    }
    void Update()
    {
        highScoreDisplay.SetText("Score:" + score.ToString());

        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.Save();
        }
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
        score++;
        return score.ToString();
    }
}
