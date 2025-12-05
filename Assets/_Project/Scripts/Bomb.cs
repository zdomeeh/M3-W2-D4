using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return; // Deve colpire solo il Player

        LifeController life = other.GetComponent<LifeController>(); // Prende LifeController dal Player


        if (life != null)
        {
            life.TakeDamage(damage); // Applica danno
        }
        else 
        {
            Debug.LogWarning("Attenzione! Il Player non ha un LifeController");
        }

        Destroy(gameObject);
    }
}
