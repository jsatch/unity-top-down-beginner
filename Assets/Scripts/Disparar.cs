using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject bala;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var firePosition = transform.position + transform.forward * 1f;
            Instantiate(bala, firePosition, bala.transform.rotation);
        }
    }
}
