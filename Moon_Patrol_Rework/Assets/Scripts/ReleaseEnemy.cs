using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    EnemyInvoke trigger;

    void Start()
    {



        
    }

    // Update is called once per frame
   

  void OnTriggerEnter2D(Collider2D other)
  {
      if(other.gameObject.tag == "Body")
      {

      trigger.EnablingEnemy1();
      trigger.EnablingEnemy2();
      trigger.EnablingEnemy3();
      trigger.EnablingEnemy4();


      }

  }

}
