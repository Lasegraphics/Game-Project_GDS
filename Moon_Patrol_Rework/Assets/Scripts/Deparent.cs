using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deparent : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject itsActive;
    void Start()
    {
        
       


    }

    // Update is called once per frame
    void Update()
    {

        if(itsActive.activeSelf == true)
        {

            gameObject.transform.parent = null;

           


        }

        if (gameObject.transform.parent == null)
        
        {
            Destroy(this.gameObject, 5);


        }
        
    }
}
