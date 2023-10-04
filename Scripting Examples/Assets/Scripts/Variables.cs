using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Public Global/Member Variables
    public int Score = 0; // declare whole number
    public float ItemAmount = 19.95f; // declare decimal number
    public string PlayerName = "John Doe"; // declare a text
    public bool IsPlayerActive = true; // declare true/false

    // Private Gloabal/Member Variables
    private int _collectibleAmount = 0;
    private float _horizontalInput = 0f;
    private string _userName = "Jane Doe";
    private bool _isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // maske sure Score variable = 0
        Score = 0; // assignming a Global/Member variable
    }

    // Update is called once per frame
    void Update()
    {
        // declare a local variable to track Start Position
    }
}
