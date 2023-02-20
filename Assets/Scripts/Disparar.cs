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
            var firePosition = transform.position + transform.forward * 2f;
            //Instantiate(bala, firePosition, bala.transform.rotation);

            var rot = Quaternion.LookRotation(transform.forward, Vector3.up);

            //var balaRotation = Quaternion.Euler(90f, 0f, 0f);
            Debug.Log(rot);
            Instantiate(bala, firePosition, rot);
        }
    }
}
