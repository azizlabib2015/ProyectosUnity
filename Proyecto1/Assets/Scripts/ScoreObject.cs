using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour {

    public int scorePerHit = 10;
    public ScoreManager manager;
    

    private void Start()
    {
        manager =GameObject.FindObjectOfType<ScoreManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(scorePerHit + " puntos");
        manager.AddScore(scorePerHit);

    }
}
