using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") == true)  // Goes from Start Screen to Running game if the player pressed SPACE (Jump).
        {
            SceneManager.LoadScene(1);
        }
    }
}
