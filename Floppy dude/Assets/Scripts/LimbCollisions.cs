using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollisions : MonoBehaviour

{
    public GameObject dude;
    private void OnTriggerEnter2D(Collider2D trigger)  // Checks collision with both the ground and the pipes.
    {
        if (trigger.gameObject.tag != "Safe")
        {
            if (trigger.gameObject.tag != "HighScore")
            {
                Lose();
            }
            
        }
    }
    public void Lose()
    {
        Destroy(dude);
        Scene_Management.Load_Scene(2);
    }
}
