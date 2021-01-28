using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingEnemyE : MonoBehaviour
{
    // ReleaseEnemy tylko ze dla sceny E-J

    BombInvokeE bombTrigger;
    EnemyInEJ trigger;
    void Start()
    {

          trigger = GameObject.Find("Manager").GetComponent<EnemyInEJ>();
          bombTrigger = GameObject.Find("Manager").GetComponent<BombInvokeE>();
        

    }

    // Update is called once per frame
   

   public void OnTriggerEnter2D(Collider2D other)
  {
      
        if (other.gameObject.tag == "Player")


        {

            
            trigger.Invoke("EnablingEnemy1",7f);
            trigger.Invoke("EnablingEnemy2", 8f);
            trigger.Invoke("EnablingEnemy3", 30f);
            trigger.Invoke("EnablingEnemy4", 31f);
            trigger.Invoke("EnablingEnemy5", 32f);
            trigger.Invoke("EnablingEnemy6", 38f);
            trigger.Invoke("EnablingEnemy7", 39f);
            trigger.Invoke("EnablingEnemy8", 44f);
            trigger.Invoke("EnablingEnemy9", 45f);
            trigger.Invoke("EnablingEnemy10", 3f);
            trigger.Invoke("EnablingEnemy11", 2f);
            trigger.Invoke("EnablingEnemy12", 53f);
            trigger.Invoke("EnablingEnemy13", 52f);
            trigger.Invoke("EnablingEnemy14", 53f);
            bombTrigger.Invoke("EnablingBomb1", 9f);
            bombTrigger.Invoke("EnablingBomb2", 10f);
            bombTrigger.Invoke("EnablingBomb3", 12f);
            bombTrigger.Invoke("EnablingBomb4", 36f);
            bombTrigger.Invoke("EnablingBomb5", 54f);
            bombTrigger.Invoke("EnablingBomb6", 30f);
            bombTrigger.Invoke("EnablingBomb7", 38f);
            bombTrigger.Invoke("EnablingBomb8", 46f);
            bombTrigger.Invoke("EnablingBomb9", 13f);
            bombTrigger.Invoke("EnablingBomb10", 34f);
            bombTrigger.Invoke("EnablingBomb11", 34f);
            bombTrigger.Invoke("EnablingBomb12", 35f);
            bombTrigger.Invoke("EnablingBomb13", 33f);
            bombTrigger.Invoke("EnablingBomb14", 39f);
            bombTrigger.Invoke("EnablingBomb15", 47f);
            bombTrigger.Invoke("EnablingBomb16", 46f);
            bombTrigger.Invoke("EnablingBomb17", 40f);
            bombTrigger.Invoke("EnablingBomb18", 45f);
            bombTrigger.Invoke("EnablingBomb19", 55f);
            bombTrigger.Invoke("EnablingBomb20", 390f);
            bombTrigger.Invoke("EnablingBomb21", 35f);
            bombTrigger.Invoke("EnablingGapBomb01", 2f);
            bombTrigger.Invoke("EnablingGapBomb02", 2f);




        }

      

    }
}
