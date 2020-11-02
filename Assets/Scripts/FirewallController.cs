using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewallController : MonoBehaviour
{
    public GameObject[] objetosDesconocidos;

    void Start()
    {
        foreach(GameObject x in objetosDesconocidos)
        {
            GetComponent<GameObject>();
        }
    }

    void Update()
    {
        Debug.Log("A: "+ objetosDesconocidos[0].name);
    }
}
