using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInvoke : MonoBehaviour
{
    // Start is called before the first frame update
    // Skrypt ten opisuje stan przeciwników w scenie. 
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;
    public GameObject Enemy10;
    public GameObject Enemy11;
    public GameObject Enemy12;
    public GameObject Enemy13;
    void Start()

    {


        Enemy1.SetActive(false);
        Enemy2.SetActive(false);
        Enemy3.SetActive(false);
        Enemy4.SetActive(false);
        Enemy5.SetActive(false);
        Enemy6.SetActive(false);
        Enemy7.SetActive(false);
        Enemy8.SetActive(false);
        Enemy9.SetActive(false);
        Enemy10.SetActive(false);
        Enemy11.SetActive(false);
        Enemy12.SetActive(false);
        Enemy13.SetActive(false);
        
        
    }

    // Update is called once per frame
   

   // Metody te są aktywowane w opóźnieniu czasowym w skrypcie ReleaseEnemy

    public void EnablingEnemy1() => Enemy1.SetActive(true);
   
    public void EnablingEnemy2() => Enemy2.SetActive(true);

    public void EnablingEnemy3() => Enemy3.SetActive(true);
    
    public void EnablingEnemy4() =>  Enemy4.SetActive(true);
    public void EnablingEnemy5() =>  Enemy5.SetActive(true);
    public void EnablingEnemy6() =>  Enemy6.SetActive(true);
    public void EnablingEnemy7() =>  Enemy7.SetActive(true);
    public void EnablingEnemy8() =>  Enemy8.SetActive(true);
    public void EnablingEnemy9() =>  Enemy9.SetActive(true);
    public void EnablingEnemy10() =>  Enemy10.SetActive(true);
    public void EnablingEnemy11() =>  Enemy11.SetActive(true);
    public void EnablingEnemy12() =>  Enemy12.SetActive(true);
    public void EnablingEnemy13() =>  Enemy13.SetActive(true);





}
