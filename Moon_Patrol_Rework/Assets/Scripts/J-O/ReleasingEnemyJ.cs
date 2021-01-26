using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingEnemyJ : MonoBehaviour
{
    // ReleaseEnemy tylko ze dla sceny J-O
   BombInvoke bombTrigger;
    EnemyInvJO trigger;
    void Start()
    {

          trigger = GameObject.Find("Manager").GetComponent<EnemyInvJO>();
          bombTrigger = GameObject.Find("Manager").GetComponent<BombInvoke>();
        
    }

    // Update is called once per frame
   

   public void OnTriggerEnter2D(Collider2D other)
  {
      
        if (other.gameObject.tag == "Player")


        {

            
            trigger.Invoke("EnablingEnemy1",2f);
            trigger.Invoke("EnablingEnemy2", 2f);
            trigger.Invoke("EnablingEnemy3", 2f);
            trigger.Invoke("EnablingEnemy4", 3f);
            trigger.Invoke("EnablingEnemy5", 14f);
            trigger.Invoke("EnablingEnemy6", 14f);
            trigger.Invoke("EnablingEnemy7", 6f);
            trigger.Invoke("EnablingEnemy8", 7f);
            trigger.Invoke("EnablingEnemy9", 7f);
            trigger.Invoke("EnablingEnemy10", 15f);
            trigger.Invoke("EnablingEnemy11", 18f);
            trigger.Invoke("EnablingEnemy12", 18f);
            trigger.Invoke("EnablingEnemy13", 18f);
            trigger.Invoke("EnablingEnemy14", 15f);
            bombTrigger.Invoke("EnablingBomb1", 3f);
            bombTrigger.Invoke("EnablingBomb2", 5f);
            bombTrigger.Invoke("EnablingBomb3", 12f);
            bombTrigger.Invoke("EnablingBomb4", 25f);
            bombTrigger.Invoke("EnablingBomb5", 27f);
            bombTrigger.Invoke("EnablingBomb6", 30f);
            bombTrigger.Invoke("EnablingBomb7", 50f);
            bombTrigger.Invoke("EnablingBomb8", 55f);
            bombTrigger.Invoke("EnablingBomb9", 7f);
            bombTrigger.Invoke("EnablingBomb10", 7f);
            bombTrigger.Invoke("EnablingBomb11", 14f);
            bombTrigger.Invoke("EnablingBomb12", 12f);
            bombTrigger.Invoke("EnablingBomb13", 14f);
            bombTrigger.Invoke("EnablingBomb14", 39f);
            bombTrigger.Invoke("EnablingBomb15", 40f);
            bombTrigger.Invoke("EnablingBomb16", 42f);
            bombTrigger.Invoke("EnablingBomb17", 47f);
            bombTrigger.Invoke("EnablingBomb18", 39f);
            bombTrigger.Invoke("EnablingBomb19", 22f);
            bombTrigger.Invoke("EnablingBomb20", 10f);
            bombTrigger.Invoke("EnablingBomb21", 12f);




        }

      

    }
}
