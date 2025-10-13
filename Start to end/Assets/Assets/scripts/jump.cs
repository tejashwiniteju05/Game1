using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            transform.position += Vector3.up * 1f;
    }

}
