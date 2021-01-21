using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeStoneAn : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject Stone;
    
    void Start()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Stone == null)
        {

            Debug.Log("Działa");

        }
        
    }
}
