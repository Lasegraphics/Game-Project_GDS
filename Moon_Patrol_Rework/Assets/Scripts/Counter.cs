using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    int pointsNumber;

    public Text counterViewPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementCounter()
    {

        pointsNumber += 500;

        counterViewPoints.text = pointsNumber.ToString();


    }
}
