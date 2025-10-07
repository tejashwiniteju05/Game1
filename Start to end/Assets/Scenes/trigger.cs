using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private GameObject capsule;  // Assign Capsule in Inspector
    private Rigidbody rb;

    void Start()
    {
        if (capsule != null)
        {
            rb = capsule.GetComponent<Rigidbody>();
            rb.useGravity = false; // Initially disable gravity
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering trigger is the Player
        if (other.CompareTag("capsule"))
        {
            if (rb != null)
            {
                rb.useGravity = true; // Enable gravity when player enters trigger
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Optional: Disable gravity again when player leaves
        if (other.CompareTag("capsule"))
        {
            if (rb != null)
            {
                rb.useGravity = false;
            }
        }
    }
}
