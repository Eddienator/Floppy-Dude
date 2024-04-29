using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreDisplayer : MonoBehaviour

{
    public TMP_Text highScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore.SetText("Highscore: " + PlayerPrefs.GetInt("highscore").ToString());
    }
}
