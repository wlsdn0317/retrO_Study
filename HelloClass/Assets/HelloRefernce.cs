using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloRefernce : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb.AddForce(0,1000,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
