using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public float nextPosX, nextPosY;
    public bool activator = true;
    void Start()
    {
        
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = new Vector2(nextPosX, nextPosY);
    }
    

}
