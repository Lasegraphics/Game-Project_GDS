using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailAction : MonoBehaviour
{   public int Scene; 
    //public CarController CarController; 
    void Start()
    {

        


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {

            Application.LoadLevel (Scene);
        }

    }

}
