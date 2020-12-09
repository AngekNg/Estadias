using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewallController : MonoBehaviour
{
    public int securityLvl;
    PlayerController Playerino;

    void Start()
    {
        Playerino = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (securityLvl <= Playerino.currentData && securityLvl != 0)
            gameObject.SetActive(false);
    }
}
