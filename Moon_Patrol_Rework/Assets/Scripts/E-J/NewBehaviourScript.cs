using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{   static Text counterViewPoints;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        
        counterViewPoints = GameObject.Find("Text").GetComponent<Text>();
        Counter.pointsNumber += TimeCounter.Addpoints;
        counterViewPoints.text =Counter.pointsNumber.ToString();

        Debug.Log("Działa");

        Destroy(this.gameObject);

    }
}
