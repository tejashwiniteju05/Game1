using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Capsule")
        {
            Debug.Log("Color Changed");
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
   
    
}