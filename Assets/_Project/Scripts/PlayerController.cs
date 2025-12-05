using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rb; // Riferimento al Rigidbody per muovere il player con la fisica
    private Vector2 _input;  // Input raccolto da tastiera
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // Prende il Rigidbody2D attaccato al player
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal"); // Raccolta input da tastiera
        float v = Input.GetAxis("Vertical");  // Raccolta input da tastiera

        _input = new Vector2(h, v);

        // Normalizzazione per evitare boost diagonale
        float length = _input.magnitude;
        if (length > 1f)
            _input /= length;
    }
    private void FixedUpdate()
    {
        // Movimento usando il Rigidbody
        _rb.velocity = _input * _speed;
    }
}
