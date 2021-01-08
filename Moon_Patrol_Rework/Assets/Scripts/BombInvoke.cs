using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInvoke : MonoBehaviour
{
    // Start is called before the first frame update

    EnemyInvoke checker;

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
    void Start()
    {

        checker = GetComponent<EnemyInvoke>();
        
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

    }

    // Update is called once per frame
   

    public void EnablingBomb1() => bomb01.SetActive(true);
    public void EnablingBomb2() => bomb02.SetActive(true);
    public void EnablingBomb3() => bomb03.SetActive(true);
    public void EnablingBomb4() => bomb04.SetActive(true);
    public void EnablingBomb5() => bomb05.SetActive(true);
    public void EnablingBomb6() => bomb06.SetActive(true);
    public void EnablingBomb7() => bomb07.SetActive(true);
    public void EnablingBomb8() => bomb08.SetActive(true);
    public void EnablingBomb9() => bomb09.SetActive(true);
    public void EnablingBomb10() => bomb10.SetActive(true);
    public void EnablingBomb11() => bomb11.SetActive(true);
    public void EnablingBomb12() => bomb12.SetActive(true);
    public void EnablingBomb13() => bomb13.SetActive(true);


    public void Update()
    {
        if(checker.Enemy1 == null)
        {

            bomb01.SetActive(false);
            bomb03.SetActive(false);
            bomb09.SetActive(false);
            bomb10.SetActive(false);
        

        }
         if(checker.Enemy2 == null)
        {

            bomb02.SetActive(false);
            
        

        }
        if(checker.Enemy3 == null)
        {

            bomb11.SetActive(false);
            bomb12.SetActive(false);
        

        }
        if(checker.Enemy4 == null)
        {

            bomb13.SetActive(false);
            
        

        }
         if(checker.Enemy5 == null)
        {

            bomb04.SetActive(false);
            
        

        }

           if(checker.Enemy6 == null)
        {

            bomb05.SetActive(false);
            
        

        }
         if(checker.Enemy7 == null)
        {

            bomb06.SetActive(false);
            
        

        }

         if(checker.Enemy10 == null)
        {

            bomb07.SetActive(false);
            
        

        }

          if(checker.Enemy12 == null)
        {

            bomb08.SetActive(false);
            
        

        }



    } 


}


