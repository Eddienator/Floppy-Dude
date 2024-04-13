using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Running : MonoBehaviour
{
    public int playervel;
    public Rigidbody2D Torso;
    // Start is called before the first frame update
    void Start()
    {

        Torso = this.GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") == true)
        {
            Torso.velocity = Vector2.up * playervel;
        }
    }


    private void OnTriggerEnter2D(Collider2D trigger)  // Checks collision with both the ground and the pipes.
    {
        if (trigger.gameObject.tag != "Safe")
        {
            Lose();
        }
    }

    public void Lose()
    {
        Destroy(gameObject);
        Scene_Management.Load_Scene(2);
    }




}
