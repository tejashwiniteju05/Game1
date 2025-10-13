using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour
{

    [SerializeField] private float movespeed;

    private void Update()
    {
        movement();
    }

    void movement()
    {
        float Xvalue = Input.GetAxis("Horizontal") * movespeed* Time.deltaTime;
        float Zvalue = Input.GetAxis("Vertical") * movespeed* Time.deltaTime;

        transform.Translate(Xvalue,0,Zvalue);
    }
}