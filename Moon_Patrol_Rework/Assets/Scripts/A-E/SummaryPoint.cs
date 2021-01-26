using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummaryPoint : MonoBehaviour
{
    // Skrypt wywołuje metody wpisujące czas do tablicy podsumowującej. 

    TimeCounter catcher; 
    
    void Start()

    {
        
        
        

    }

    void Update()
    {
        catcher = GameObject.Find("Manager").GetComponent<TimeCounter>();

        if (catcher == null)
        {

            Debug.LogError("Cannot find TimeCounter");
        }

        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
      
        catcher.ItsFinish();
        catcher.AvarageTimeAE();
        catcher.TopRecord();
        Debug.Log("Wykryto");
        

        


    }



}
