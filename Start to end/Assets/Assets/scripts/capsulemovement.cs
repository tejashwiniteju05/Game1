using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class capsule : MonoBehaviour
{
    [SerializeField] float moveForce;
    [SerializeField] float jumpForce;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    void FixedUpdate()
    {
        Movement();
        Jump();
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        Vector3 movePos = new Vector3(xValue, 0, zValue).normalized;
        rb.MovePosition(rb.position + movePos * moveForce * Time.fixedDeltaTime);
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    
}