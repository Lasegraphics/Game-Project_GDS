using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    //Skrypt zawieta metody dodające punkty do zmiennej łańcuchowej klasy Text w Hudzie gry.   
    public static int pointsNumber;
    int checkingPoints = 0;
    bool itsActive = true;
    int additionalPoints;
    int convertedPoints;
    int sum;
    string intercept; 
    string masterPointsStr;
    public int pointsCatcher; 
    private bool itsTrigger = false;

    
      
    

    static Text counterViewPoints;
    static Text masterPoints;
    public static int trytake; 

    GetBonus Bonus;
    public GameObject Prefab;
    //private Text bonusTotext;
    // Start is called before the first frame update
    void Start()
    {
        itsTrigger = false;
    
        checkingPoints = 0;
        itsActive = true;
        
        //TimeCounter.Addpoints = trytake;

        //counterViewPoints.text = trytake.ToString();

        

    }

    // Update is called once per frame
    void Update()
    {   
        
        pointsCatcher = pointsCatcher; 
        try 
        {
           //Podział na dwa pola text. 
            counterViewPoints = GameObject.Find("Text").GetComponent<Text>();
            masterPoints = GameObject.Find("MasterPoints").GetComponent<Text>();
            Bonus = Prefab.GetComponent<GetBonus>();
            
            

            /*if(itsTrigger == true)
            {
                GameObject.Find("Manager").GetComponent<TimeCounter>().Addpoints = trytake;
                counterViewPoints.text = trytake.ToString();

                itsTrigger = false;
                

            }
            */
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
        if(checkingPoints ==  3 /*11 */ && itsActive == true)
        {
            
            Bonus.InstantiateBonus();
           Debug.Log("Metoda została Wywołana");
           BonusPoints500();

           itsActive = false;

           Debug.Log("Przyznano punkty");
            


        }




    }

    public void ChangeTrigger()
    {
      
      itsTrigger = true;
        


    }

    public void IncrementCounter500()
    {

        pointsNumber += 500;
         pointsCatcher += pointsNumber;
        counterViewPoints.text = pointsNumber.ToString();
         masterPoints.text = pointsNumber.ToString();

    }

     public void IncrementCounter100()
    {

        pointsNumber += 100;
        pointsCatcher += pointsNumber;
        counterViewPoints.text = pointsNumber.ToString();
        masterPoints.text = pointsNumber.ToString();


    }

      public void IncrementCounter200()
    {

        pointsNumber += 200;
        pointsCatcher += pointsNumber;
        counterViewPoints.text = pointsNumber.ToString();
         masterPoints.text = pointsNumber.ToString();

    }

    public void BonusPoints500()
    {
       
        pointsNumber += 500;
        pointsCatcher += pointsNumber;
        counterViewPoints.text = pointsNumber.ToString();
         masterPoints.text = pointsNumber.ToString();
    }

    public void CheckingPoints()
    {

        
        checkingPoints += 1;
        //Debug.Log("PRzyznano punkty");

    }



    public void TryToString()
    {

        //GameObject.Find("Manager").GetComponent<TimeCounter>().Addpoints = trytake;
        //counterViewPoints.text += trytake.ToString();

    }
    
}
