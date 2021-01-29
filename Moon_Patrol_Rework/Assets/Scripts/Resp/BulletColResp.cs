using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColResp : MonoBehaviour
{
    // Start is called before the first frame updatepublic string scenesName = "A-E";
    public int Scene;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Application.LoadLevel (Scene);
        }
        
    }
    

    public void Respawn()
    {
        Application.LoadLevel (Scene);
        GetComponent<CarController>().StrataHP();
    }
}
