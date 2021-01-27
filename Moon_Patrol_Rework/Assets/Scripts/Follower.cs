using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{

    //Skrypt odpowiedzialny za przypisanie obiektu w tym przypadku przeciwnika do ściezki w obiekcie Path.  
    public PathCreator pathCreator;
    
    public float speed = 5;

    float distanceTravelled;


    void Update()

    {

        distanceTravelled += speed * Time.deltaTime;

        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    } 
   


   
}
