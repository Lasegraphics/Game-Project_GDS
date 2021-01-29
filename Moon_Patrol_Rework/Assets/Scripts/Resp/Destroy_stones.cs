using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_stones : MonoBehaviour
{

    public GameObject Anim;

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            SoundManagerScript.PlaySound("destroy");
            Destroy(gameObject);
            Anim.SetActive(true);
           
        }
    }
}
