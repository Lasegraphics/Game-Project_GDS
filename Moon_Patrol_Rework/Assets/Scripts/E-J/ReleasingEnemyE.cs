using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingEnemyE : MonoBehaviour
{
    // Start is called before the first frame update  EnemyInvoke trigger;

    BombInvoke bombTrigger;
    EnemyInEJ trigger;
    void Start()
    {

          trigger = GameObject.Find("Manager").GetComponent<EnemyInEJ>();
          bombTrigger = GameObject.Find("Manager").GetComponent<BombInvoke>();
        
    }

    // Update is called once per frame
   

   public void OnTriggerEnter2D(Collider2D other)
  {
      
        if (other.gameObject.tag == "Body")


        {

            
            trigger.Invoke("EnablingEnemy1",2f);
            trigger.Invoke("EnablingEnemy2", 2f);
            trigger.Invoke("EnablingEnemy3", 9f);
            trigger.Invoke("EnablingEnemy4", 10f);
            trigger.Invoke("EnablingEnemy5", 52);
            trigger.Invoke("EnablingEnemy6", 53);
            trigger.Invoke("EnablingEnemy7", 30f);
            trigger.Invoke("EnablingEnemy8", 31f);
            trigger.Invoke("EnablingEnemy9", 31f);
            trigger.Invoke("EnablingEnemy10", 38f);
            trigger.Invoke("EnablingEnemy11", 39f);
            trigger.Invoke("EnablingEnemy12", 44f);
            trigger.Invoke("EnablingEnemy13", 45f);
            trigger.Invoke("EnablingEnemy14", 53f);
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
