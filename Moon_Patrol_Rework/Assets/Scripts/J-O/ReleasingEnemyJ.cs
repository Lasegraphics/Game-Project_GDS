using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingEnemyJ : MonoBehaviour
{
    // Start is called before the first frame update
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
      
        if (other.gameObject.tag == "Body")


        {

            
            trigger.Invoke("EnablingEnemy1",40f);
            trigger.Invoke("EnablingEnemy2", 41f);
            trigger.Invoke("EnablingEnemy3", 41f);
            trigger.Invoke("EnablingEnemy4", 42f);
            trigger.Invoke("EnablingEnemy5", 48f);
            trigger.Invoke("EnablingEnemy6", 49f);
            trigger.Invoke("EnablingEnemy7", 49f);
            trigger.Invoke("EnablingEnemy8", 54);
            trigger.Invoke("EnablingEnemy9", 54f);
            trigger.Invoke("EnablingEnemy10", 55f);
            trigger.Invoke("EnablingEnemy11", 56f);
            trigger.Invoke("EnablingEnemy12", 59f);
            trigger.Invoke("EnablingEnemy13", 59f);
            trigger.Invoke("EnablingEnemy14", 60f);
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
