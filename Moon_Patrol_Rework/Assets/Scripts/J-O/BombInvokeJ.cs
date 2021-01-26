using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInvokeJ : MonoBehaviour
{
    // BombInvoke tylko ze dla sceny J-O
    EnemyInvJO checker;

    public GameObject bomb01;
    public GameObject bomb02;
    public GameObject bomb03;
    public GameObject bomb04;
    public GameObject bomb05;
    public GameObject bomb06;
    public GameObject bomb07;
    public GameObject bomb08;
    public GameObject bomb09;
    public GameObject bomb10;
    public GameObject bomb11;
    public GameObject bomb12;
    public GameObject bomb13;
    public GameObject bomb14;
    public GameObject bomb15;
    public GameObject bomb16;
    public GameObject bomb17;
    public GameObject bomb18;
    public GameObject bomb19;
    public GameObject bomb20;
    public GameObject bomb21;
    void Start()
    {

        checker = GetComponent<EnemyInvJO>();
        
        bomb01.SetActive(false);
        bomb02.SetActive(false);
        bomb03.SetActive(false);
        bomb04.SetActive(false);
        bomb05.SetActive(false);
        bomb06.SetActive(false);
        bomb07.SetActive(false);
        bomb08.SetActive(false);
        bomb09.SetActive(false);
        bomb10.SetActive(false);
        bomb11.SetActive(false);
        bomb12.SetActive(false);
        bomb13.SetActive(false);
        bomb14.SetActive(false);
        bomb15.SetActive(false);
        bomb16.SetActive(false);
        bomb17.SetActive(false);
        bomb18.SetActive(false);
        bomb19.SetActive(false);
        bomb20.SetActive(false);
        bomb21.SetActive(false);

    }

    // Update is called once per frame
   

    public void EnablingBomb1() 
    {

        try 
        {
            bomb01.SetActive(true);
        }
        catch
        {

            Debug.Log("Proces zatrzymany");

        }
        

    }

    
    public void EnablingBomb2()
    {
        try 
        {

            bomb02.SetActive(true);

        }
        catch 
        {
           
            Debug.Log("Proces zatrzymany");


        }
        

    } 


    public void EnablingBomb3() 
    {
        try 
        {
            bomb03.SetActive(true);

        }
        catch
        {
            
            Debug.Log("Proces zatrzymany");

        }
        

    } 
    public void EnablingBomb4() 
    {
        try 
        {
            bomb04.SetActive(true);

        }
        catch
        {

             Debug.Log("Proces zatrzymany");

        }
        

    } 

    public void EnablingBomb5() 
     {
         try 
         {

             bomb05.SetActive(true);

         }
         catch
         {

             Debug.Log("Proces zatrzymany");

         }
          
     }


    
    public void EnablingBomb6() 
    {
        try 
        {
            bomb06.SetActive(true);  

        }
        catch 
        {
             Debug.Log("Proces zatrzymany");

        }
        

    }
        
        
    public void EnablingBomb7()
    {
        try
        {
             bomb07.SetActive(true);
        }
        catch 
        {
             Debug.Log("Proces zatrzymany");
            
        }
       

    } 
    public void EnablingBomb8() 
    {
        try
        {
            bomb08.SetActive(true);
        }
        catch
        {
            
            Debug.Log("Proces zatrzymany");
           
        }

    } 
    public void EnablingBomb9() 
    {
        try
        {
           bomb09.SetActive(true); 
        }
        catch 
        {
             Debug.Log("Proces zatrzymany");
           
        }


    } 
    public void EnablingBomb10()
    {
        try
        {
            bomb10.SetActive(true);
        }
        catch 
        {
           Debug.Log("Proces zatrzymany");

        }
         


    } 

    public void EnablingBomb11() 
    {
        try
        {
            bomb11.SetActive(true);
        }
        catch 
        {
            Debug.Log("Proces zatrzymany");     
            
        }
    } 
    public void EnablingBomb12()
    {

        try
        {
            bomb12.SetActive(true);
        }
        catch 
        {
            Debug.Log("Proces zatrzymany");     
         
        }

    } 

    public void EnablingBomb13()
    {
        try
        {
            bomb13.SetActive(true);
        }
        catch 
        {
             Debug.Log("Proces zatrzymany");
            
        }

    }
    public void EnablingBomb14() 
    {
        try
        {
            bomb14.SetActive(true);
        }
        catch 
        {
            Debug.Log("Proces zatrzymany");
            
        }


    } 
    public void EnablingBomb15() 
    {
        try
        {
            bomb15.SetActive(true);
        }
        catch 
        {
            Debug.Log("Proces zatrzymany");

        }



    } 
    public void EnablingBomb16() 
    {
        try
        {
            bomb16.SetActive(true);
        }
        catch 
        {
            
            Debug.Log("Proces zatrzymany");
           
        }
    } 
    public void EnablingBomb17() 
    {

        try
        {
            bomb17.SetActive(true);
        }
        catch 
        {
            Debug.Log("Proces zatrzymany");
            
        }

    } 
    public void EnablingBomb18() 
    {
        try
        {
            bomb18.SetActive(true);
        }
        catch 
        {
             Debug.Log("Proces zatrzymany");
            
        }

    } 
    public void EnablingBomb19() 
    {
        try
        {
            bomb19.SetActive(true);
        }
        catch 
        {
             
             Debug.Log("Proces zatrzymany");
            
        }

    } 
    public void EnablingBomb20()  
    {
        try
        {
            bomb20.SetActive(true);
        }
        catch 
        {
             Debug.Log("Proces zatrzymany");
            
        }

    } 
    public void EnablingBomb21() 
    {
        try
        {
          bomb21.SetActive(true);

        }
        catch 
        {
          Debug.Log("Proces zatrzymany");
            
        }

    } 

    public void Update()
    {
        if(checker.Enemy1 == null)
        {
            try 
            {
                bomb01.SetActive(false);
                bomb03.SetActive(false);
                bomb09.SetActive(false);
                bomb10.SetActive(false);
            }
            catch
            {

                Debug.Log("Obiekt został zniszczony");

            }
            
            
        

        }
         if(checker.Enemy2 == null)
        {
            try 
            {
                bomb02.SetActive(false);

            } 
            catch
            {

                Debug.Log("Obiekt został zniszczony");

            }

            
            
        

        }
        if(checker.Enemy3 == null)
        {

            try 
            {
                 bomb11.SetActive(false);
                 bomb12.SetActive(false);
                 bomb20.SetActive(false);

            }
            catch 
            {
                
                Debug.Log("Obiekt został zniszczony");

            }
           
        

        }
        if(checker.Enemy4 == null)
        {
            try 
            {
                bomb13.SetActive(false);
                bomb21.SetActive(false);
            }
            catch 
            {
                
                Debug.Log("Obiekt został zniszczony");
                
            }
            

        }
         if(checker.Enemy5 == null)
        {

            try 
            {
            
             bomb04.SetActive(false);


            }
            catch 
            {

                Debug.Log("Obiekt został zniszczony");

            }
           
            
        

        }

        if(checker.Enemy6 == null)
        {
            try 

            {
                  bomb05.SetActive(false);
                  bomb19.SetActive(false);

            }
            catch 
            {
               
                Debug.Log("Obiekt został zniszczony");

            }

          

        }
         if(checker.Enemy7 == null)
        {

            try 
            {
                bomb06.SetActive(false);
                bomb14.SetActive(false);

            }
            catch 
            {
                Debug.Log("Obiekt został zniszczony");


            }
            
            
        

        }
          if(checker.Enemy8 == null)
        {

            try 
            {
                bomb18.SetActive(false);

            }
            catch
            {
                Debug.Log("Obiekt został zniszczony");


            }
            
            
            
        

        }

         if(checker.Enemy9 == null)
        {

            try 
            {
                bomb15.SetActive(false);
                bomb16.SetActive(false);

            }
            catch
            {
                Debug.Log("Obiekt został zniszczony");
                
            }


        

        }
         if(checker.Enemy10 == null)
        {

            try 
            {
                bomb07.SetActive(false);
                bomb17.SetActive(false);

            }
            catch
            {
                 Debug.Log("Obiekt został zniszczony");

            }
            
            
        

        }

          if(checker.Enemy12 == null)
        {
            try 
            {

                bomb08.SetActive(false);
            }

            catch
            {
                 Debug.Log("Obiekt został zniszczony");


            }
            
            
        

        }



    } 
}
