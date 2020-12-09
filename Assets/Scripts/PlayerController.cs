using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region variables
    Rigidbody2D rb;
    public int speed;
    public int currentData = 0;
    public Animator camAnim;
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
        Movement();
    }

    void Movement()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Enemy")
        {
            Death();
        }
        if (collision.tag == "Dato")
        {
            Destroy(collision.gameObject);
            currentData++;
        }
    }

    void Death()
    {
        Destroy(gameObject);
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gc.gameOver();
        camAnim.SetTrigger("Shake");
    }
}