using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabling : MonoBehaviour
{
    // Start is called before the first frame update
    
    private SpriteRenderer sprRen;

    void Start()
    {
        sprRen = GetComponent<SpriteRenderer>();


    }
    
    public void En()
    {

            sprRen.enabled = true;


    }
}
