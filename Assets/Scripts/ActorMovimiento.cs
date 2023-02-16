using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ActorMovimiento : MonoBehaviour
{
    public float velocidad;

    private Rigidbody mRb;

    private void Start()
    {
        mRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movVec = new Vector3(
            Input.GetAxis("Horizontal"),
            0f,
            Input.GetAxis("Vertical")
        ).normalized;

        mRb.MovePosition(transform.position + (movVec * Time.deltaTime * velocidad));
    }
}
