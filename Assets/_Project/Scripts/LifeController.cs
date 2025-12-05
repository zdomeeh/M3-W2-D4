using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    private int _health = 100;

    public void TakeDamage(int damage) // Funzione che toglie vita
    {
        _health -= damage;


        if ( _health < 0) // Evita vita negativa
            _health = 0;
        Debug.Log($"{gameObject.name} ha subito {damage} danni. | Vita attuale: {_health}");

        
        if (_health == 0) // Se la vita arriva a 0 muore
        {
            Debug.Log("Il giocatore e' stato sconfitto");
            Destroy(gameObject);
        }
    }
    public void TakeHeal(int amount) // Funzione che aggiunge vita
    {
       _health += amount;
        Debug.Log($"{gameObject.name} è stato curato di {amount}. Vita attuale: {_health}");
    }
}
