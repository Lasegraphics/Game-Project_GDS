﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerScript : MonoBehaviour
{
    public Animator anim; 
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame

   public void InvokeDan()
    {

        anim.SetTrigger("ItsActive");

    }


}
