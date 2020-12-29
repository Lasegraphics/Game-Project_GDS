using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetMov : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed; 

    public Rigidbody2D rb;

    void Start()
    {
        
        
        transform.localScale = new Vector2(1,1);

        Invoke("StartMov",2f);

        Invoke("EndStartMov",3f);


    }

    void StartMov()

    {




                rb.AddForce(new Vector2(speed,0),ForceMode2D.Impulse);

                 //transform.Translate(2* Time.deltaTime * speed, 0,0);

          
    
    }


    void EndStartMov()
    {

         rb.velocity = Vector2.zero;

    }




}
