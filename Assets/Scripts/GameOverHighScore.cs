using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverHighScore : MonoBehaviour
{

    [SerializeField] Text HighScoreText;
    [SerializeField] Text CurrentScoreText;

    // Start is called before the first frame update
    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HIGHSCORE");
        int currentScore = PlayerPrefs.GetInt("LAST_SCORE");

        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HIGHSCORE", highScore);
        }

        if (HighScoreText)
            HighScoreText.text = highScore.ToString();
        if (CurrentScoreText)
            CurrentScoreText.text = currentScore.ToString();
    }


    

}
