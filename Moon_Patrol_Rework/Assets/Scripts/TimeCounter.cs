﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeCounter : MonoBehaviour
{
    Counter Trymethod;
    //Skrypt wylicza i przekazuje informacje o czasie rozgrywki do zmiennej łańcuchowej typu Text w hudzie gry. Uwzględnione jest takze obliczanie oraz dodawanie puntkow bonusowych. 
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
    public int difference;
    int intercept; 
    int basicValue = 1000;
    private Text bonusTotext;
    static Text counterViewPoints;
   public static int actualValue;
    bool enable = false;
    public static int Addpoints;
    

    void Start()
    {
        //enable = true;
        
        startTime = Time.time;
    
    }
    void Update()
    {  
    
        // zmienne pobierają informacje o lokalizacji docelowej i zawartości.
        try
        {
            timeCounter = GameObject.Find("Timer").GetComponent<Text>();
            finalTime = GameObject.Find("YourTime").GetComponent<Text>();
            tpRecord = GameObject.Find("TopRecord").GetComponent<Text>();
            avTime = GameObject.Find("Text (3)").GetComponent<Text>();
            bonusTotext = GameObject.Find("Text (4)").GetComponent<Text>();
            counterViewPoints = GameObject.Find("MainPoints").GetComponent<Text>();
            
               tpRecord.text = topRecord;


        }
        catch
        {

                Debug.Log("Nie Pobrano");
        }
        
        //instrukcja warunkowa posiadająca wartość logiczną sprawdza czy pojazd dotarł do końca etapu wtedy czas przestaje być liczony a uruchamiane są instrukcje odpowiedzialne za podsumowanie
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

           difference = i - timeSum;

           
            

        }

        else
        {

              finalTime.text = minutes + dozens + units;
            
              
             



           //  difference = hiddenTopRecord - timeSum;

                intercept = 1000 + difference * 100;
                if(enable == true)
                {
                    

                    Counter.pointsNumber += intercept;

                    counterViewPoints.text = Counter.pointsNumber.ToString();
                    int.TryParse(counterViewPoints.text, out actualValue);
                    //Addpoints = intercept + actualValue;
                    //ounterViewPoints.text = (intercept + actualValue).ToString();
                    enable = false;
                    //Trymethod.TryToString();
                }
                else 
                {

                        Debug.Log("Nie dodano punktów bonusowych");

                }
                
                //counterViewPoints.text = intercept.ToString();
                
            
            
            if(basicValue <= intercept)
                
             {
               string ToText=basicValue.ToString();

               
                //bonusTotext.text = intercept.ToString();
                bonusTotext.text = ToText;
                basicValue +=100;  
            
             }

             

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
