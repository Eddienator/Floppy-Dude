using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Running : MonoBehaviour
{
    public int playervel;
    public List<Rigidbody2D> player = new List<Rigidbody2D>(); 
    
    void Start()
    {

        
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") == true)
        {
            player[0].velocity = Vector2.up * playervel;
        }
    }
}
