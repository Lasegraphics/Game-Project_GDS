using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    //Skrypt zawieta metody dodające punkty do zmiennej łańcuchowej klasy Text w Hudzie gry.   
    static int pointsNumber;
    int checkingPoints = 0;
    bool itsActive = true;

    int additionalPoints;
    int convertedPoints;
    int sum;
    string intercept; 
    string masterPointsStr;
      
    

    static Text counterViewPoints;
    static Text masterPoints;
    //private Text bonusTotext;
    // Start is called before the first frame update
    void Start()
    {
      
        checkingPoints = 0;
        itsActive = true;

        

    }

    // Update is called once per frame
    void Update()
    {   
        try 
        {
           //Podział na dwa pola text. 
            counterViewPoints = GameObject.Find("Text").GetComponent<Text>();
            masterPoints = GameObject.Find("MasterPoints").GetComponent<Text>();
            //counterViewPoints.text = masterPointsStr;
            //masterPoints.text = masterPointsStr;



            //bonusTotext = GameObject.Find("Text (4)").GetComponent<Text>();

            //addBonusSum();
            //TimeCounter pointsDif = new TimeCounter();
           // additionalPoints = pointsDif.difference;
           // bonusTotext.text = additionalPoints.ToString();

            /*if(timeSum <= i)
                
             {
                number=i.ToString();

                avTime.text = "0" + number; 
                i--;  
            
             }
             */
        }
        catch
        {
            Debug.Log("Nie Pobrano");

        }
        
        //System aktywacji punktów bonusowych. instrukcja warunkowa sprawdza czy uzyskane są punkty prywatne za zestrzelenie przeciwnika, oraz warunek zabezpieczający przed wielokrotnym uzyciem metody.   
        if(checkingPoints == 11 && itsActive == true)
        {

           BonusPoints500();

           itsActive = false;

           Debug.Log("Przyznano punkty");
            


        }




    }

    public void addBonusSum()
    {
       //TimeCounter pointsDif = new TimeCounter();
       //additionalPoints = pointsDif.difference * 100;

        // counterViewPoints.text = intercept;

            //convertedPoints = int.Parse(intercept);
         

        //sum = additionalPoints + convertedPoints + 1000;
        


    }

    public void IncrementCounter500()
    {

        pointsNumber += 500;

        counterViewPoints.text = pointsNumber.ToString();
         masterPoints.text = pointsNumber.ToString();

    }

     public void IncrementCounter100()
    {

        pointsNumber += 100;

        counterViewPoints.text = pointsNumber.ToString();
        masterPoints.text = pointsNumber.ToString();


    }

      public void IncrementCounter200()
    {

        pointsNumber += 200;

        counterViewPoints.text = pointsNumber.ToString();
         masterPoints.text = pointsNumber.ToString();

    }

    public void BonusPoints500()
    {
       
        pointsNumber += 500;

        counterViewPoints.text = pointsNumber.ToString();
         masterPoints.text = pointsNumber.ToString();
    }

    public void CheckingPoints()
    {

        
        checkingPoints += 1;

    }



  
    
}
