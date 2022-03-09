using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetScript : MonoBehaviour
{
    Score score;
    private AudioSource audioSource;
    public AudioClip arrowSound;
    private void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<Score>();
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        score.ScoreManager(10);
        audioSource.clip = arrowSound;
        audioSource.Play();
    }
}
