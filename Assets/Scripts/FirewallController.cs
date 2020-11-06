using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewallController : MonoBehaviour
{
    public int Nivel_Seguridad;
    PlayerController Playerino;

    void Start()
    {
        Playerino = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (Nivel_Seguridad <= Playerino.puntos && Nivel_Seguridad != 0)
            gameObject.SetActive(false);
    }
}
