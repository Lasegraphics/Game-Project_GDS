using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    EnemyInvoke trigger;

    BombInvoke bombTrigger;

    public int EnemyT1;
    public int EnemyT2;
    public int EnemyT3;
    public int EnemyT4;
    public int EnemyT5;
    public int EnemyT6;
    public int EnemyT7;
    public int EnemyT8;
    public int EnemyT9;
    public int EnemyT10;
    public int EnemyT11;
    public int EnemyT12;
    public int EnemyT13;
    public int BombT1;
    public int BombT2;
    public int BombT3;
    public int BombT4;
    public int BombT5;
    public int BombT6;
    public int BombT7;
    public int BombT8;
    public int BombT9;
    public int BombT10;
    public int BombT11;
    public int BombT12;
    public int BombT13;
    public int BombT14;
    public int BombT15;
    public int BombT16;
    public int BombT17;
    public int BombT18;
    public int BombT19;
    public int BombT20;
    public int BombT21;
    public int GapBombT01;
    public int GapBombT02;
   // public int Bomb19;

      

   //Skrypt przechowuje informacje na temat bramek czasowych dla wywołania przeciwników w momencie trigger obiektu EnemyTrigger  
    void Start()
    {

          trigger = GameObject.Find("Manager").GetComponent<EnemyInvoke>();
          bombTrigger = GameObject.Find("Manager").GetComponent<BombInvoke>();
        
    }

    // Update is called once per frame
   

   public void OnTriggerEnter2D(Collider2D other)
  {
      
        if (other.gameObject.tag == "Player")


        {

            
            trigger.Invoke("EnablingEnemy1",EnemyT1);
            trigger.Invoke("EnablingEnemy2", EnemyT2);
            trigger.Invoke("EnablingEnemy3", EnemyT3);
            trigger.Invoke("EnablingEnemy4", EnemyT4);
            trigger.Invoke("EnablingEnemy5", EnemyT5);
            trigger.Invoke("EnablingEnemy6", EnemyT6);
            trigger.Invoke("EnablingEnemy7", EnemyT7);
            trigger.Invoke("EnablingEnemy8", EnemyT8);
            trigger.Invoke("EnablingEnemy9", EnemyT9);
            trigger.Invoke("EnablingEnemy10", EnemyT10);
            trigger.Invoke("EnablingEnemy11", EnemyT11);
            trigger.Invoke("EnablingEnemy12", EnemyT12);
            trigger.Invoke("EnablingEnemy13", EnemyT13);
            bombTrigger.Invoke("EnablingBomb1", BombT1);
            bombTrigger.Invoke("EnablingBomb2", BombT2);
            bombTrigger.Invoke("EnablingBomb3", BombT3);
            bombTrigger.Invoke("EnablingBomb4", BombT4);
            bombTrigger.Invoke("EnablingBomb5", BombT5);
            bombTrigger.Invoke("EnablingBomb6", BombT6);
            bombTrigger.Invoke("EnablingBomb7", BombT7);
            bombTrigger.Invoke("EnablingBomb8", BombT8);
            bombTrigger.Invoke("EnablingBomb9", BombT9);
            bombTrigger.Invoke("EnablingBomb10", BombT10);
            bombTrigger.Invoke("EnablingBomb11", BombT11);
            bombTrigger.Invoke("EnablingBomb12", BombT12);
            bombTrigger.Invoke("EnablingBomb13", BombT13);
            bombTrigger.Invoke("EnablingBomb14", BombT14);
            bombTrigger.Invoke("EnablingBomb15", BombT15);
            bombTrigger.Invoke("EnablingBomb16", BombT16);
            bombTrigger.Invoke("EnablingBomb17", BombT17);
            bombTrigger.Invoke("EnablingBomb18", BombT18);
            bombTrigger.Invoke("EnablingBomb19", BombT19);
            bombTrigger.Invoke("EnablingBomb20", BombT20);
            bombTrigger.Invoke("EnablingBomb21", BombT21);
            bombTrigger.Invoke("EnablingGapBomb01",GapBombT01);
            bombTrigger.Invoke("EnablingGapBomb02",GapBombT02);




        }

      

  }

}
