using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject objectToSpawn; 
    SpriteRenderer spriteR; 
    
    void Start()
    {
        
        spriteR = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D (Collider2D other)
    {

        
        Instantiate(objectToSpawn, transform.position, transform.rotation);

        spriteR.isVisible();

    }


}
