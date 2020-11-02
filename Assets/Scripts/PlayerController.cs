using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public int velocidad;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movimiento();
        //Debug.Log(Input.GetAxis("Horizontal"));
    }

    void FixedUpdate()
    {
        
    }

    void Movimiento()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*velocidad, Input.GetAxisRaw("Vertical")*velocidad);
    }
}
