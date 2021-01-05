using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInvoke : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bomb01;
    public GameObject bomb02;
    public GameObject bomb03;
    public GameObject bomb04;
    public GameObject bomb05;
    public GameObject bomb06;
    public GameObject bomb07;
    public GameObject bomb08;

    void Start()
    {
        
        bomb01.SetActive(false);
        bomb02.SetActive(false);
        bomb03.SetActive(false);
        bomb04.SetActive(false);
        bomb05.SetActive(false);
        bomb06.SetActive(false);
        bomb07.SetActive(false);
        bomb08.SetActive(false);

    }

    // Update is called once per frame
   

    public void EnablingBomb1() => bomb01.SetActive(true);
    public void EnablingBomb2() => bomb02.SetActive(true);
    public void EnablingBomb3() => bomb03.SetActive(true);
    public void EnablingBomb4() => bomb04.SetActive(true);
    public void EnablingBomb5() => bomb05.SetActive(true);
    public void EnablingBomb6() => bomb06.SetActive(true);
    public void EnablingBomb7() => bomb07.SetActive(true);
    public void EnablingBomb8() => bomb08.SetActive(true);
}
