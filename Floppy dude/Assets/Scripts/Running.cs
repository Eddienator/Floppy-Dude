using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Running : MonoBehaviour
{
    public int playervel;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") == true)
        {
            player.velocity = Vector2.up * playervel;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Safe")
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
