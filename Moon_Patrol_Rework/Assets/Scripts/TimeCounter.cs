using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeCounter : MonoBehaviour
{
    bool lvlFin = false;
    
    public Text timeCounter;
    public Text finalTime;
    private float startTime;
    string seconds;
    string minutes;
    string dozens;
    string units; 
    //private int hiddenmin;
   // private int hiddendozens;
   // private int hiddenunits;
    //private int timeSum;
    string number;
    int i= 0;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        



    }

    // Update is called once per frame
    void Update()
    {

        if(lvlFin == false)
        {

        
            float t = Time.time - startTime; 

           // hiddenmin = ((int) t / 100);
           // hiddendozens = ((int)t / 10);
           // hiddenunits = ((int)t % 10);
            minutes = ((int) t / 100).ToString();
            dozens = ((int)t / 10).ToString();
            units = ((int)t % 10).ToString();

            if (dozens =="10")
            {

                dozens = "0"; 

            }    

            timeCounter.text = minutes + dozens + units;
            
           // timeSum = hiddenmin + hiddendozens + hiddenunits;
            

        }

        else
        {

              finalTime.text = minutes + dozens + units;
            
            /*if(i <= timeSum)
           {
                number=i.ToString();

                finalTime.text = number; 
                i++;  
            
           }
            */
                



        }


    }

    public void ItsFinish()
    {

        lvlFin = true; 
    }    




         
        




}
