using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int _score = 0;
    public float _health = 100.0f;

    // public float startDelay = 1.5f;
    // public float interval = 1.5f;
    public string PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IncreaseScore()
    {
        _score = _score + 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth()
    {
        _health = _health - 20;
    }
}
