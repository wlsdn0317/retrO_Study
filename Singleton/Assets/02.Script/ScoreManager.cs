using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager GetInstance()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<ScoreManager>();

            if(instance == null)
            {
                GameObject container = new GameObject("Score Manager");

                instance = container.AddComponent<ScoreManager>();
            }
        }

        return instance;
    }

    private static ScoreManager instance;

    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score = score + newScore;
    }

    private void Start()
    {
        if(instance != null)
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

}
