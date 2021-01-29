using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_stones : MonoBehaviour
{

    public GameObject Anim;
    Counter counter;
    void Start()
    {

        counter = GameObject.Find("Manager").GetComponent<Counter>();
        
        if (counter == null)
        {

            Debug.LogError("Cannot find Counter");
        }



    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            SoundManagerScript.PlaySound("destroy");
            counter.IncrementCounter100();
            Destroy(gameObject);
            Anim.SetActive(true);


           
        }
    }
}
