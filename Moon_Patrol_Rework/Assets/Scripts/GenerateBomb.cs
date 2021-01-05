using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBomb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bombPrefab;

    
    void Start()
    {


        GameObject bomb = (GameObject)Instantiate(bombPrefab);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
