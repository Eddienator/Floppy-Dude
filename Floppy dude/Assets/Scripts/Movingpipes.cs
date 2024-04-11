using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingpipes : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vel;
    void Start()
    {
        rb.velocity = transform.right * -vel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
