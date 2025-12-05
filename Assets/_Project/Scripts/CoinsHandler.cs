using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    private int _coinsCount = 0;

    public void AddCoins (int amount = 1) // Funzione per aggiungere coins
    {
        _coinsCount += amount;
        Debug.Log($"{gameObject.name} ha ottenuto {_coinsCount} monete!");
    }
}
