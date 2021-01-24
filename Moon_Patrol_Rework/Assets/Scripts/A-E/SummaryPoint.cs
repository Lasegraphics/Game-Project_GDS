using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummaryPoint : MonoBehaviour
{
    // Start is called before the first frame update

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
