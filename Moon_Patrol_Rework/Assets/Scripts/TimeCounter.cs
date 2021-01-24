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
    string topUnits; 
    string topRecord;
    string topSeconds;
    string topMinutes;
    string topDozens;
    private Text tpRecord;
    private Text avTime;
    private int hiddenmin;
    private int hiddendozens;
    private int hiddenunits;
    private int hiddenTopMin;
    private int hiddenTopDozens;
    private int hiddenTopUnits;
    private int timeSum;
    private int hiddenTopRecord;
    string number;
    int i= 70;
    private int difference;
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

               tpRecord.text = topRecord;


        }
        catch
        {

                Debug.Log("Nie Pobrano");
        }
        
        if(lvlFin == false)
        {

        
            float t = Time.time - startTime; 

            hiddenmin = ((int) t / 100);
            hiddendozens = ((int)t / 10);
            hiddenunits = ((int)t % 10);
            minutes = ((int) t / 100).ToString();
            dozens = ((int)t / 10).ToString();
            units = ((int)t % 10).ToString();

            if (dozens =="10")
            {

                dozens = "0"; 

            }    

            timeCounter.text = minutes + dozens + units;
            
           timeSum = hiddendozens  * 10  + hiddenunits * 1;
            

        }

        else
        {

              finalTime.text = minutes + dozens + units;
            
              

             difference = hiddenTopRecord - timeSum;

             //avTime.text = difference.ToString(); 
             //avTime.text = difference.ToString();
            if(timeSum <= i)
                
             {
                number=i.ToString();

                avTime.text = "0" + number; 
                i--;  
            
             }
            
            


        }


    }

    public void ItsFinish()
    {
        Debug.Log("lvlFin działa");

        lvlFin = true; 
    }    

    public void TopRecord()
    {
        topMinutes = (0/ 100).ToString();
        topDozens = (70 / 10).ToString();
        topUnits = (0 % 10).ToString();
        
        topRecord = topMinutes + topDozens + topUnits;
        
        Debug.Log("TopRecord działa");


    }

    public void AvarageTimeAE()
    {
 
        hiddenTopRecord = 70;
        Debug.Log("AvarageTime działa");
      
          
    }
                




         
        




}
