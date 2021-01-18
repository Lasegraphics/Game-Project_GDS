using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up_Dziury : MonoBehaviour
{
    Counter counter;

    void Start()
    {
        counter = GameObject.Find("Manager").GetComponent<Counter>();
        
        if (counter == null)
        {

            Debug.LogError("Cannot find Counter");
        }

    }

    void OnTriggerEnter2D (Collider2D other)
    {
            counter.IncrementCounter500();
    }
}
