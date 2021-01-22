using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resp : MonoBehaviour
{
    public string scenesName = "A-E";

    void OnCollisionEnter2D()
    {
        Application.LoadLevel (scenesName);

    }
    

    public void Respawn()
    {
        Application.LoadLevel (scenesName);
        GetComponent<CarController>().StrataHP();
    }
}

