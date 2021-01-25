using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    EnemyInvoke trigger;

    BombInvoke bombTrigger;


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

            
            trigger.Invoke("EnablingEnemy1",1f);
            trigger.Invoke("EnablingEnemy2", 2f);
            trigger.Invoke("EnablingEnemy3", 7f);
            trigger.Invoke("EnablingEnemy4", 8f);
            trigger.Invoke("EnablingEnemy5", 14f);
            trigger.Invoke("EnablingEnemy6", 16f);
            trigger.Invoke("EnablingEnemy7", 28f);
            trigger.Invoke("EnablingEnemy8", 29f);
            trigger.Invoke("EnablingEnemy9", 30f);
            trigger.Invoke("EnablingEnemy10", 36f);
            trigger.Invoke("EnablingEnemy11", 38f);
            trigger.Invoke("EnablingEnemy12", 40f);
            trigger.Invoke("EnablingEnemy13", 41f);
            bombTrigger.Invoke("EnablingBomb1", 1f);
            bombTrigger.Invoke("EnablingBomb2", 4f);
            bombTrigger.Invoke("EnablingBomb3", 2f);
            bombTrigger.Invoke("EnablingBomb4", 18f);
            bombTrigger.Invoke("EnablingBomb5", 18f);
            bombTrigger.Invoke("EnablingBomb6", 29f);
            bombTrigger.Invoke("EnablingBomb7", 50f);
            bombTrigger.Invoke("EnablingBomb8", 42f);
            bombTrigger.Invoke("EnablingBomb9", 5f);
            bombTrigger.Invoke("EnablingBomb10", 16f);
            bombTrigger.Invoke("EnablingBomb11", 8f);
            bombTrigger.Invoke("EnablingBomb12", 10f);
            bombTrigger.Invoke("EnablingBomb13", 12f);
            bombTrigger.Invoke("EnablingBomb14", 31f);
            bombTrigger.Invoke("EnablingBomb15", 32f);
            bombTrigger.Invoke("EnablingBomb16", 34f);
            bombTrigger.Invoke("EnablingBomb17", 47f);
            bombTrigger.Invoke("EnablingBomb18", 31f);
            bombTrigger.Invoke("EnablingBomb19", 20f);
            bombTrigger.Invoke("EnablingBomb20", 10f);
            bombTrigger.Invoke("EnablingBomb21", 11f);
            bombTrigger.Invoke("EnablingGapBomb01",36f);




        }

      

  }

}
