using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resp : MonoBehaviour
{

   // private Text counterViewPoints;
    public string scenesName = "A-E";
    //private int Takeit;

    void Update()
    {
     
    }
    void OnCollisionEnter2D()
    {
       
        //counterViewPoints = GameObject.Find("Text").GetComponent<Text>();
       // GameObject.Find("Next_Scene").GetComponent<EJ_Resp>().TakePoints = Takeit;
       // counterViewPoints.text = Takeit.ToString();

        Application.LoadLevel (scenesName);


       

    }
    

    public void Respawn()
    {
        Application.LoadLevel (scenesName);
        GetComponent<CarController>().StrataHP();
    }
}

