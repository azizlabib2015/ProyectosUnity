using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : MonoBehaviour {

    public TextMesh text;
	// Use this for initialization
	void Start () {
		text=GameObject.FindObjectOfType<TextMesh>();
    }
	
	public void  setScore(int score)
    {
        string scoreText = "score: " + score;
        text.text = scoreText;
    }
}
