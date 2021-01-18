using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deparent : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject Enemies; 
    public GameObject itsActive;
    void Start()
    {
        
       
        Enemies = GameObject.Find("Enemy Paths");

    }

    // Update is called once per frame
    void Update()
    {
        try 
        {
            if(itsActive.activeSelf == true)
            {  

                gameObject.transform.parent = Enemies.transform;

           


            }

                if (gameObject.transform.parent == Enemies.transform)
        
                {
                 Destroy(this.gameObject, 2);


                }

        }
        catch
        {

            Debug.Log("Błąd");
        }
        
        
    }
}
