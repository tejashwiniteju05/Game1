using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{
    [SerializeField] float moveForce = 100f;
    Rigidbody body;
    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.freezeRotation = true;
    }
    private void FixedUpdate()
    {
        movementlogic();
    }
    private void movementlogic()
    {
        float xvalue = Input.GetAxis("Horizontal");
        float zvalue = Input.GetAxis("Vertical");
        Vector3 movedir = (transform.right * xvalue + transform.forward * zvalue);
        body.AddForce(movedir * moveForce, ForceMode.Force);
    }


}
