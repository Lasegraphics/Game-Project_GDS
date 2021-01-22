using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDaneger : MonoBehaviour
{
        DangerScript danger;
    // Start is called before the first frame update
    void Start()
    {

         danger = GameObject.Find("iceshard").GetComponent<DangerScript>();

    }
     void OnTriggerEnter2D (Collider2D other)
     {

        danger.InvokeDan();


     }
}
