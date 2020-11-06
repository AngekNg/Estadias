using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{ 
 public int Nivel_Seguridad;
PlayerController Playerino;
// Start is called before the first frame update
void Start()
{
    Playerino = FindObjectOfType<PlayerController>();
}

// Update is called once per frame
void Update()
{
    if (Nivel_Seguridad <= Playerino.puntos && Nivel_Seguridad != 0)
        gameObject.SetActive(false);
}
}

