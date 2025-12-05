using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private int coins = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return; // Controlla che chi entra nel trigger sia il Playe

        CoinsHandler ch = other.GetComponent<CoinsHandler>();  // Cerca il componente CoinsHandler nel Player
        
        if (ch != null )
        {
            ch.AddCoins(coins); // Aggiunge le monete al Player
        }
        else
        {
            Debug.LogWarning("Attenzione! Il Player non ha CoinsHandler!");
        }
        Destroy(gameObject);
    }
}
