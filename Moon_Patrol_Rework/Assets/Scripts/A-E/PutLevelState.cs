using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PutLevelState : MonoBehaviour
{
    // Start is called before the first frame update

    public string Letter; 
    private Text PutState;
    void Start()
    {
            PutState = GameObject.Find("LevelState").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag =="Player")
        {
            
            PutState.text = Letter; 


        }
        



    }


}
