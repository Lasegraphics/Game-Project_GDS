using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDaneger : MonoBehaviour
{
        DangerScript danger;
    // Skrypt wysyła informacje o momencie aktywacji informacji danger w hudzie gry. 
    void Start()
    {

        
    }

    void Update()
    {
         try 
         {
              danger = GameObject.Find("iceshard").GetComponent<DangerScript>();

         }
         catch
         {
              Debug.Log("Nie pobrano");

         }
          


    }
     void OnTriggerEnter2D (Collider2D other)
     {

        danger.InvokeDan();


     }
}
