using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColResp : MonoBehaviour
{
    // Start is called before the first frame updatepublic string scenesName = "A-E";
    public string scenesName = "A-E";
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Body")
        {
            Application.LoadLevel (scenesName);
        }
        
    }
    

    public void Respawn()
    {
        Application.LoadLevel (scenesName);
        GetComponent<CarController>().StrataHP();
    }
}
