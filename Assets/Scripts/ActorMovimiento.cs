using Cinemachine.Utility;
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
        );

        //mRb.MovePosition(transform.position + (movVec * Time.deltaTime * velocidad));
        mRb.MovePosition(transform.position + transform.forward * movVec.z * Time.deltaTime * velocidad);

        transform.Rotate(0f, 45f * movVec.x * Time.deltaTime , 0f);


       /* movVec = Quaternion.AngleAxis(Camera.main.transform.rotation.eulerAngles.y, Vector3.up) * movVec;
        movVec.Normalize();


        if (movVec != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movVec, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 90f * Time.deltaTime);
        }*/
    }
}
