using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToHole : MonoBehaviour
{
    // Start is called before the first frame update
   Animator toHole;
   CarController controller;
   //public string scenesName = "A-E";
    //private int Takeit;
    static Text counterViewPoints;
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       //counterViewPoints = GameObject.Find("Text").GetComponent<Text>();
       //Counter.pointsNumber = TimeCounter.actualValue;
      // counterViewPoints.text = Counter.pointsNumber.ToString(); 

       //GetComponent<Animator>().enabled = true;
       toHole = GameObject.Find("New_Car").GetComponent<Animator>();
        controller = GameObject.Find("New_Car").GetComponent<CarController>();
        controller.enabled = false;
       toHole.enabled = true;


        toHole.SetTrigger("ToHole");
        //counterViewPoints = GameObject.Find("Text").GetComponent<Text>();
       // GameObject.Find("Next_Scene").GetComponent<EJ_Resp>().TakePoints = Takeit;
       // counterViewPoints.text = Takeit.ToString();
        //Invoke("Respawn",4f);
      //  Application.LoadLevel (scenesName);


       

    }
    

    /*public void Respawn()
    {
        Application.LoadLevel (scenesName);
        GetComponent<CarController>().StrataHP();
    }
    */
}
