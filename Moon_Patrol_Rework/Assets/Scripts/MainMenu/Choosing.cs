using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{
    // Skrypt opisujący wybór opcji w menu głównym gry. 

     public string scenesName = "A-E";

 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.A))
        {

           Invoke("LoadLevel",2f);

        }
        else if(Input.GetKeyDown(KeyCode.B))
        {

             Invoke("QuitApp",2f);
        }
        
    }

    void LoadLevel()
    {

        Application.LoadLevel(scenesName);
    }

    void QuitApp()
    {
         
         Application.Quit();


    }



}
