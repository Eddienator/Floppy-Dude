using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingpipes : MonoBehaviour
{
    public Rigidbody2D rbpipe;
    public float vel;
    void Start()
    {
        rbpipe.velocity = transform.right * -vel;
    }

    // Update is called once per frame
    void Update()
    {
        if (rbpipe.transform.position.x < -50)
        {
            Destroy(gameObject);
        }
    }
}
