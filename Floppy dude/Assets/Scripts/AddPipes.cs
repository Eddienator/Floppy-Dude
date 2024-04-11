using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPipes : MonoBehaviour
{
    public int time;
    public GameObject pipe;
    void Start()
    {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator timer()
    {
        addPipe();
        yield return new WaitForSeconds(2);
        StartCoroutine(timer());
    }
    void addPipe()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.y + Random.Range(-5, 3));
        Instantiate(pipe,pos,Quaternion.identity);
    }
}
