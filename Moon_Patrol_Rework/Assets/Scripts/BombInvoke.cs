using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInvoke : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bomb01;
    public GameObject bomb02;
    public GameObject bomb03;
    void Start()
    {
        
        bomb01.SetActive(false);
        bomb02.SetActive(false);
        bomb03.SetActive(false);

    }

    // Update is called once per frame
   

    public void EnablingBomb1() => bomb01.SetActive(true);
    public void EnablingBomb2() => bomb02.SetActive(true);
    public void EnablingBomb3() => bomb03.SetActive(true);
}
