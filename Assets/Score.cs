using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    public Text textScore;
    public SpriteRenderer sprite;
    public bool isGameWin = false;
    private void Start()
    {
        sprite.enabled = false;
    }


    private void Update()
    {
        textScore.text = score.ToString();          

    }

    public void ScoreManager(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log("Score : " +score);
        if  (score > 50)
        {
            sprite.enabled = true;
            isGameWin = true;
        }

    }
}
