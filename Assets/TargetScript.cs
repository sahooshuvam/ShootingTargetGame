using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TargetScript : MonoBehaviour
{
    Score score;
    private void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<Score>();
    }
    private void OnMouseDown()
    {

        Destroy(gameObject);
        score.ScoreManager(10);

        
    }
}
