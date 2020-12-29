using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetMov : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed; 

    private int whilecount  = 0; 

    void Start()
    {
        
        
        transform.localScale = new Vector2(1,1);

        FinalMov();


    }

    // Update is called once per frame
    void Update()
    {
        
        


    }

    void FinalMov()

    {
        while(whilecount < 5)
        {


            transform.Translate(2* Time.deltaTime * speed, 0,0);

            whilecount++;


        }


    }




}
