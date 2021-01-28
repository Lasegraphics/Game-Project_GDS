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

            
            trigger.Invoke("EnablingEnemy1",10f);
            trigger.Invoke("EnablingEnemy2", 3f);
            trigger.Invoke("EnablingEnemy3", 6f);
            trigger.Invoke("EnablingEnemy4", 7f);
            trigger.Invoke("EnablingEnemy5", 57f);
            trigger.Invoke("EnablingEnemy6", 59f);
            trigger.Invoke("EnablingEnemy7", 30f);
            trigger.Invoke("EnablingEnemy8", 31f);
            trigger.Invoke("EnablingEnemy9", 31f);
            trigger.Invoke("EnablingEnemy10", 3f);
            trigger.Invoke("EnablingEnemy11", 2f);
            trigger.Invoke("EnablingEnemy12", 44f);
            trigger.Invoke("EnablingEnemy13", 45f);
            trigger.Invoke("EnablingEnemy14", 58f);
            bombTrigger.Invoke("EnablingBomb1", 3f);
            bombTrigger.Invoke("EnablingBomb2", 5f);
            bombTrigger.Invoke("EnablingBomb3", 12f);
            bombTrigger.Invoke("EnablingBomb4", 54f);
            bombTrigger.Invoke("EnablingBomb5", 54f);
            bombTrigger.Invoke("EnablingBomb6", 30f);
            bombTrigger.Invoke("EnablingBomb7", 38f);
            bombTrigger.Invoke("EnablingBomb8", 46f);
            bombTrigger.Invoke("EnablingBomb9", 7f);
            bombTrigger.Invoke("EnablingBomb10", 53f);
            bombTrigger.Invoke("EnablingBomb11", 14f);
            bombTrigger.Invoke("EnablingBomb12", 12f);
            bombTrigger.Invoke("EnablingBomb13", 8f);
            bombTrigger.Invoke("EnablingBomb14", 39f);
            bombTrigger.Invoke("EnablingBomb15", 33f);
            bombTrigger.Invoke("EnablingBomb16", 36f);
            bombTrigger.Invoke("EnablingBomb17", 40f);
            bombTrigger.Invoke("EnablingBomb18", 33f);
            bombTrigger.Invoke("EnablingBomb19", 55f);
            bombTrigger.Invoke("EnablingBomb20", 10f);
            bombTrigger.Invoke("EnablingBomb21", 10f);
            bombTrigger.Invoke("EnablingGapBomb01", 2f);




        }

      

    }
}
