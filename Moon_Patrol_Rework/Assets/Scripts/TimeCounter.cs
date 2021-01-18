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
    private int hiddenmin;
    private int hiddensec;
    private int timeSum;
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

            hiddenmin = ((int) t / 60);
            hiddensec = ((int)t % 60);
            minutes = ((int) t / 60).ToString();
            seconds = ((int)t % 60).ToString();

            timeCounter.text = minutes + seconds;
            
            timeSum = hiddenmin + hiddensec;
            

        }

        else
        {
            
            if(i <= timeSum)
           {
                number=i.ToString();

                finalTime.text = number; 
                i++;  
            
           }

                



        }


    }

    public void ItsFinish()
    {

        lvlFin = true; 
    }    




         
        




}
