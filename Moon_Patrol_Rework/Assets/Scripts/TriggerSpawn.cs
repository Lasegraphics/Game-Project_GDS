using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{

    Spawner spawn;
   public GameObject objectToDestroy;

   public GameObject toActive;

    //public Enabling enabling;
    

   
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("SpawnPoint").GetComponent<Spawner>();

        //enabling = GetComponent<Enabling>();

    }

    // Update is called once per frame
    

    void OnTriggerEnter2D(Collider2D other)
    {
        
        spawn.OnSpawn();
        toActive.SetActive(true);
        Destroy(this.gameObject);
//         Destroy(objectToDestroy);
    }
}
