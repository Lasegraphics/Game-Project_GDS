using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerScript : MonoBehaviour
{
    public Animator anim; 
    // Skrypt aktywuje animacje danger. 

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
