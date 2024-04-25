using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movingpipes : MonoBehaviour
{
    public Rigidbody2D rigidBodyPipe;
    public float velocity;
    void Start()
    {
        rigidBodyPipe.velocity = transform.right * -velocity;
    }

    void Update()
    {
        if (rigidBodyPipe.transform.position.x < -50)
        {
            Destroy(gameObject);
        }
        
        
    }


}
