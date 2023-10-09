using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOnecodingChallenge : MonoBehaviour
{
    private int _score = 0;
    private float _Health = 100.0f;

    // public float startDelay = 1.5f;
    // public float interval = 1.5f;
    public string PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IncreaseScore(int amount)
    {
        _score = amount + 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth(float amount)
    {
        _Health = amount - 20;
    }
}
