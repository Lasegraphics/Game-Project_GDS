using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummaryPoint : MonoBehaviour
{
    // Start is called before the first frame update

    TimeCounter catcher; 
    
    void Start()

    {
        catcher = GameObject.Find("Manager").GetComponent<TimeCounter>();
        
        if (catcher == null)
        {

            Debug.LogError("Cannot find TimeCounter");
        }


    }

    void Update()
    {

        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
      

        catcher.ItsFinish();

        Debug.Log("Wykryto");


    }


}
