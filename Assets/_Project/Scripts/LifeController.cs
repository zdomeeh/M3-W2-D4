using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    private int _health = 100;

    public void TakeDamage(int damage) 
    {
        _health -= damage;
        Debug.Log($"{gameObject.name} ha subito {damage} danni. | Vita attuale: {_health}");
        
        if (_health <= 0)
        {
            Debug.Log("Il giocatore e' stato sconfitto");
            Destroy(gameObject);
        }
    }
    void TakeHeal(int amount) 
    {
       _health += amount;
        Debug.Log($"{gameObject.name} è stato curato di {amount}. Vita attuale: {_health}");
    }

    void Start()
    {
        
    }


    void Update()
    {
       
    }
}
