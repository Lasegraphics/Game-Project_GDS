using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetMov : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed; 

    void Start()
    {
        
        
        transform.localScale = new Vector2(1,1);



    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(2* Time.deltaTime * speed, 0,0);


    }
}
