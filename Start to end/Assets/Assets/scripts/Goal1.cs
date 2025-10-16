using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
    [SerializeField] ParticleSystem endparticles;
    void Start()
    {
        endparticles.Stop();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Capsule") 
        {
            endparticles.Play();
        }
    }
}
