using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private int healAmount = 20;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return; // Deve curare solo il Player

        LifeController life = other.GetComponent<LifeController>(); // Prende LifeController dal Player

        if (life != null)
        {
            life.TakeHeal(healAmount); // Cura il player
        }
        else
        {
            Debug.LogWarning("Attenzione! Il player non ha LifeController");
        }
        Destroy(gameObject);
    }
}
