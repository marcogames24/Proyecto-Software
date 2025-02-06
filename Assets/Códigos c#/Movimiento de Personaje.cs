using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientodePersonaje : MonoBehaviour
{
    
    
    public float moveSpeed = 5f; // Velocidad de movimiento
    public float jumpForce = 10f; // Fuerza del salto
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D
    }

    void Update()
    {
        // Movimiento horizontal
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Salto
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}


