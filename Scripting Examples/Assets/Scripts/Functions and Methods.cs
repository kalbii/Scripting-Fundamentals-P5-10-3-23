using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsandMethods : MonoBehaviour
{
    private int _playerHealthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method Examples

    // This Method is accessable from other files because it is Public

    public void UpdatePlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;
    }

    private void IncreaseScore()
    {
       // IncreaseScore++;
    }
}
