
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
        movementLogic();
    }
    private void movementLogic()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movedirection = (transform.right * x + transform.forward * z);
        body.AddForce(moveForce * movedirection, ForceMode.Force);
    }

}