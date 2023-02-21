using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BalaMovimiento : MonoBehaviour
{
    public float aceleracion;
    private Rigidbody mRb;

    private void Start()
    {
        mRb = GetComponent<Rigidbody>();
        float mass = mRb.mass;
        mRb.AddForce(transform.forward * mass * aceleracion, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
