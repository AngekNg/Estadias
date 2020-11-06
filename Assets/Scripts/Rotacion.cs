using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float velocidad;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f,0f, velocidad * Time.deltaTime);
    }
}
