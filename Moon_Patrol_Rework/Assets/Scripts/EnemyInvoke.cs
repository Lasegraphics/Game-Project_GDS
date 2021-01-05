using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInvoke : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;


    public GameObject Enemy4;

    void Start()

    {


        Enemy1.SetActive(false);
        Enemy2.SetActive(false);
        Enemy3.SetActive(false);
        Enemy4.SetActive(false);
        
       
        
        
    }

    // Update is called once per frame
   

    public void EnablingEnemy1() => Enemy1.SetActive(true);
   
    public void EnablingEnemy2() => Enemy2.SetActive(true);

    public void EnablingEnemy3() => Enemy3.SetActive(true);
    
    public void EnablingEnemy4() =>  Enemy4.SetActive(true);
 





}
