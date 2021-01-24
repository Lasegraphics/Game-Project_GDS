using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeCounter : MonoBehaviour
{
    bool lvlFin = false;
    
    private Text timeCounter;
    private Text finalTime;
    private float startTime;
    string seconds;
    string minutes;
    string dozens;
    string units; 
    string topRecord ="abc";
    private Text tpRecord;
    private Text avTime;
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
        try
        {
            timeCounter = GameObject.Find("Timer").GetComponent<Text>();
            finalTime = GameObject.Find("Text (1)").GetComponent<Text>();
            tpRecord = GameObject.Find("TopRecord").GetComponent<Text>();
            avTime = GameObject.Find("Text (3)").GetComponent<Text>();


        }
        catch
        {

                Debug.Log("Nie Pobrano");
        }
        
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
            
          



        }


    }

    public void ItsFinish()
    {
        Debug.Log("lvlFin działa");

        lvlFin = true; 
    }    

    public void TopRecord()
    {
        
        tpRecord.text = topRecord;
        Debug.Log("TopRecord działa");


    }

    public void AvarageTimeAE()
    {
        //tpRecord.text = "070";
        Debug.Log("AvarageTime działa");
      /*if(i <= timeSum)
           {
                number=i.ToString();

                finalTime.text = number; 
                i++;  
            
           }
            */
    }
                




         
        




}
