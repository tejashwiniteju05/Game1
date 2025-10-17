using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0, 360f, 0) * Time.deltaTime);
    }
}
