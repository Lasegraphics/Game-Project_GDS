using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject objectToSpawn; 


   public void OnSpawn()
   {
    
    
        Instantiate(objectToSpawn, transform.position, transform.rotation);


        

   }

       

    


}
