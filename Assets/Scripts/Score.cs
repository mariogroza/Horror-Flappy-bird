using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public Text score;
    public Text Highscore;
    public Text Retry;
    public Text Retry1;
    public SpriteRenderer Jeff;
    private int points = 0;
    public Rigidbody2D rb;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Point")
        {
            points++;
            score.text = "" + points;
            if(points > PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", points);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb.GetComponent<BoxCollider2D>().enabled == false)
        {
            Highscore.text += PlayerPrefs.GetInt("HighScore");
            if (Jeff.GetComponent<SpriteRenderer>().enabled == false)
            {
                Highscore.enabled = true;
                Retry.enabled = true;
            }
            else
            {
                score.enabled = false;
                Retry1.enabled = true;
            }
        }
    }
}
