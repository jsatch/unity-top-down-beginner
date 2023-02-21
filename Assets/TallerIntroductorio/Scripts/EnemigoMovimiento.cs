using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemigoMovimiento : MonoBehaviour
{
    public float velocidad = 2f;

    private float mTimer = 0f;
    private float mMaxTime = 3f;
    private Rigidbody mRb;

    private void Start()
    {
        mRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        mTimer += Time.deltaTime;

        if (mTimer > mMaxTime)
        {
            RotateRandom();
            mTimer= 0f;
        }
    }

    private void RotateRandom()
    {
        var randomRotation = UnityEngine.Random.Range(-180f, 180f);
        transform.Rotate(new Vector3(
            0f,
            randomRotation,
            0f
        ));

    }

    private void FixedUpdate()
    {
        mRb.MovePosition(
            transform.position + transform.forward * velocidad * Time.fixedDeltaTime
        );
    }
}
