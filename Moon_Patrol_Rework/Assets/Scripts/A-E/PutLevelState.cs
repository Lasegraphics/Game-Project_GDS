using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PutLevelState : MonoBehaviour
{
    // Wpisuje do zmiennej łańcuchowej informacje o Etapie w momencie wywołania OnTriggerEnter 

    public string Letter; 
    private Text PutState;
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
         PutState = GameObject.Find("LevelState").GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag =="Player")
        {
            
            PutState.text = Letter; 


        }
        



    }


}
