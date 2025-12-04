using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rb;
    private Vector2 _input;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _input = new Vector2(h, v);

        // Normalizzazione per evitare boost diagonale
        float length = _input.magnitude;
        if (length > 1f)
            _input /= length;
    }
    private void FixedUpdate()
    {
        // Movimento usando il Rigidbody (come richiesto)
        _rb.velocity = _input * _speed;
    }
}
