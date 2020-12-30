using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPingPong : MonoBehaviour
{
    public Transform navStartPoint;

    public Transform navEndPoint;

    public Vector2 startPoint;
    public Vector2 endPoint;

    public float pingSpeed; 


    public Vector2 currentPosition;


    // Start is called before the first frame update
    void Start()
    {


        startPoint = navStartPoint.position;
        endPoint = navEndPoint.position;
    

        Invoke("Update", 3f);


        
    }

    // Update is called once per frame
    void Update()
    {


        startPoint = navStartPoint.position;
        endPoint = navEndPoint.position;
        currentPosition = Vector2.Lerp(startPoint,endPoint,Mathf.PingPong(Time.time * pingSpeed,1));
        transform.position = currentPosition;

        
    }
}
