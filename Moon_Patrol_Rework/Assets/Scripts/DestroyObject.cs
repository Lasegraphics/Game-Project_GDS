using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

   public GameObject objectType;
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

    void Update ()
    {

 



    }

    // Update is called once per frame
    
    void OnTriggerEnter2D(Collider2D other)
    {

        
        if(other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);

            counter.CheckingPoints();

           

        }

        try
        {
                if (objectType.gameObject.tag =="Points100")
        
                {
                 counter.IncrementCounter100();

                 Debug.Log("Przyznano punkty");

                
                 }
                else if (objectType.gameObject.tag =="Points200")
                {

                    counter.IncrementCounter200();

                }

                 else if (objectType.gameObject.tag =="Points500")
                {

                    counter.IncrementCounter500();

                }
        }
        catch 
        {
            Debug.Log("Nie pobrano informacji o punktach");        
    
        }

        
        
        
       

        



    }
}
