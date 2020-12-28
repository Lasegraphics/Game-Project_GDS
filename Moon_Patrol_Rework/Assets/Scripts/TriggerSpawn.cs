using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{

    Spawner spawn;
   public GameObject objectToDestroy;

    Enabling enabling;
    

   
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("SpawnPoint").GetComponent<Spawner>();

        enabling = GameObject.Find("Ice").GetComponent<Enabling>();

    }

    // Update is called once per frame
    

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
        spawn.OnSpawn();

        Destroy(objectToDestroy);
        
        enabling.En();


    }
}
