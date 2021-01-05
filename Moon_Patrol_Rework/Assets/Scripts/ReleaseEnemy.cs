using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    EnemyInvoke trigger;

    BombInvoke bombTrigger;

    void Start()
    {

          trigger = GameObject.Find("Manager").GetComponent<EnemyInvoke>();
          bombTrigger = GameObject.Find("Manager").GetComponent<BombInvoke>();
        
    }

    // Update is called once per frame
   

   public void OnTriggerEnter2D(Collider2D other)
  {
      
      if (other.gameObject.tag == "Body")


      {

         
      trigger.Invoke("EnablingEnemy1",1f);
      trigger.Invoke("EnablingEnemy2", 2f);
      trigger.Invoke("EnablingEnemy3", 10f);
      trigger.Invoke("EnablingEnemy4", 10f);
      bombTrigger.Invoke("EnablingBomb1", 3f);
      bombTrigger.Invoke("EnablingBomb2", 5f);
      bombTrigger.Invoke("EnablingBomb2", 12f);





      }

      

  }

}
