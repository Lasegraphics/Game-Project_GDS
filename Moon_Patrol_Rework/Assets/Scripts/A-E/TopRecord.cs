using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopRecord : MonoBehaviour
{
    // Start is called before the first frame update TimeCounter catcher; 
    TimeCounter topRec;
    void Start()

    {
        
        
        

    }

    void Update()
    {
        topRec = GameObject.Find("Manager").GetComponent<TimeCounter>();

        if (topRec == null)
        {

            Debug.LogError("Cannot find TimeCounter");
        }

        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
      
        if(other.gameObject.tag == "Player")
        {
           
            topRec.TopRecord();
             Debug.Log("Wykryto");


        }
    
 
        

        


    }
}
