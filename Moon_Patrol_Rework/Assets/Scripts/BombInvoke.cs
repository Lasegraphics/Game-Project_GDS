using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInvoke : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bomb01;
   

    void Start()
    {
        
        bomb01.SetActive(false);



    }

    // Update is called once per frame
   

    public void EnablingBomb1() => bomb01.SetActive(true);
}
