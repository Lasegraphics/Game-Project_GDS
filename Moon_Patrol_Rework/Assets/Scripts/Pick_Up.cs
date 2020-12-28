using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up : MonoBehaviour
{

    Counter counter;

    
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Manager").GetComponent<Counter>();
        
        if (counter == null)
        {

            Debug.LogError("Cannot find Counter");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D (Collider2D other)
    {
        
        
            Destroy (this.gameObject);

            counter.IncrementCounter();


        


    }
}
