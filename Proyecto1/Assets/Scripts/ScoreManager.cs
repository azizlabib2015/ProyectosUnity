using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    public int currentScore;
    public ScoreText scoreText;
     void Start()
    {
        ResetScore();

    }
    public void AddScore(int score)
    {
        currentScore += score;
        scoreText.setScore(currentScore);
    }

    public void ResetScore()
    {
        currentScore = 0;
        scoreText.setScore(0);
    }
}
