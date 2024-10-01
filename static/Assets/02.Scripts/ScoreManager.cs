using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<int> scores = new List<int>();

    void Start()
    {
        while(scores.Count > 0)
        {
            scores.RemoveAt(0);
        }    
    }



    //[45][60][75]

    //private void Start()
    //{
    //    int score0 = 45;
    //    int score1 = 60;
    //    int score2 = 75;

    //    scores.Add(score0);
    //    scores.Add(score1);
    //    scores.Add(score2);

    //    scores.Remove(60);

    //    Debug.Log(scores[1]);

    //}




    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        int randomNumber = Random.Range(0, 100);
    //        scores.Add(randomNumber);
    //    }

    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        scores.RemoveAt(3);
    //    }

    //}
}
