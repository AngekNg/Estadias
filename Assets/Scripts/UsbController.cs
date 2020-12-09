using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsbController : MonoBehaviour
{
    public string nivel;
    StageController stg;

    private void Start()
    {
        stg = FindObjectOfType<StageController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Levelino());
    }

    IEnumerator Levelino()
    {
        yield return new WaitForSeconds(1.5f);
        stg.ChangeLevel(nivel);
    }
}
