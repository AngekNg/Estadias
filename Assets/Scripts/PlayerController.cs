using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region variables generales
    Rigidbody2D rb;
    public int velocidad;
    #endregion

    #region Datos de Absorción
    public float rangoAbsorción;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movimiento();
        if(Input.GetKey(KeyCode.Z))
        Absorción();
    }

    void FixedUpdate()
    {
        
    }

    void Movimiento()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*velocidad, Input.GetAxisRaw("Vertical")*velocidad);
    }

    void Absorción()
    {
        RaycastHit2D colisiónAbsorbción = Physics2D.CircleCast(transform.position, rangoAbsorción, Vector2.zero);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, rangoAbsorción);
    }

}
