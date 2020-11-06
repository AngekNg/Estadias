using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region variables generales
    Rigidbody2D rb;
    public int velocidad;
    public int puntos = 0;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidad, Input.GetAxisRaw("Vertical") * velocidad);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Firewall" || collision.tag == "Star" || collision.tag == "Enemy")
        {
            Morir();

        }
        if (collision.tag == "Dato")
        {
            puntos++;
            collision.gameObject.SetActive(false);
        }
        if (collision.tag == "USB1")
        {
            SceneManager.LoadScene("2ndScene");
        }
        if (collision.tag == "USB2")
        {
            SceneManager.LoadScene("3rdScene");
        }

    }

    void Morir()
    {
            Destroy(gameObject);
            GameObject obj = GameObject.FindGameObjectWithTag("GameController");
            GameController gc = obj.GetComponent<GameController>();
            gc.gameOver();
    }
}