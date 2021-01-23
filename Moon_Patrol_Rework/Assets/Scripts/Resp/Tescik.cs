using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tescik : MonoBehaviour
{
    public Transform startPoint;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "New_Car")
        {
            other.transform.position = startPoint.position;
        }    
    }
}
