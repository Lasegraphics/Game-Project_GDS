using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabling : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public SpriteRenderer sprRen;
    
    void Start()
    {
    


    }
    
    public void En()
    {
        sprRen = GetComponent<SpriteRenderer>();
        sprRen.enabled = true;


    }
}
