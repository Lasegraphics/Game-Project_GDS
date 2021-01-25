using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour
{
    // Start is called before the first frame update
    //Skrypt przypsuje połozenie wszystkich sciezek przeciwników do obecnego połozenia kamery w scenie. 
    public Transform target; 
    public Vector3 offset; 
    
    void Start()
    {

        offset = transform.position - target.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = target.position + offset;
        
    }
}
