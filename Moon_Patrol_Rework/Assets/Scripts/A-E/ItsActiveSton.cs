﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItsActiveSton : MonoBehaviour
{

    public float destroyTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf == true)
        {

            Destroy(gameObject, destroyTime);

        }
        
    }
}
