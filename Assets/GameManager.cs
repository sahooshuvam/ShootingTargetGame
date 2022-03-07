using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Score score;
    public GameObject targetPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMethed",1f,1f);
        score = GameObject.Find("ScoreManager").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score.isGameWin == true)
        {
            CancelInvoke("SpawnMethed");
        }
    }

    private void SpawnMethed()
    {
        float xRandom = UnityEngine.Random.Range(-1f,3.5f);
        float yRandom = UnityEngine.Random.Range(-7f,7f);
        Instantiate(targetPrefab,new Vector3(xRandom,yRandom,0),Quaternion.identity);
    }
}


// put some audio 
// Win game >> Apply Win Sound
//Lost game >> "Play again"
