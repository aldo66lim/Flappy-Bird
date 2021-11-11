using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public AudioSource scoreSound;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreDetect")
        {
            scoreSound.Play();
            score = score + 1;
            scoreText.text = "" + score;
        }
    }

}
