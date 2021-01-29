using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EJ_Resp : MonoBehaviour
{
    //Skrypt zzawietajcy metody wczytujące następną scenę w momencie kontaktu trigger z polem na końcu trasy. 
    TimeCounter catcher;
    //Counter invokeTrig;
        public int x;
     public static string BeginLevelPoints;
    
   public int TakePoints;
  
    void Start()
    {
         
          catcher = GameObject.Find("Manager").GetComponent<TimeCounter>();
          
        if (catcher == null)
        {

            Debug.LogError("Cannot find TimeCounter");
        }

    }

    void Update()
    {

        BeginLevelPoints = BeginLevelPoints;


    }


    void OnTriggerEnter2D(Collider2D other)
    {
        

        if(other.gameObject.tag == "Player")
        {

            GameObject.Find("Manager").GetComponent<Counter>().pointsCatcher = TakePoints;

            BeginLevelPoints = TakePoints.ToString();
            
            
             Invoke("LoadSummary",1f);
             Invoke("LoadNewScene", 6f);
             catcher.ItsFinish();
             catcher.AvarageTimeAE();
             catcher.TopRecord();
             //invokeTrig.TryToString();
             Debug.Log("Wykryto");
        
       //this.gameObject.SetActive(false);

        }
       
       
    }


    void LoadNewScene()
    {

         SceneManager.LoadScene(x);

    }

    void LoadSummary()
    {

        SceneManager.LoadScene("Assets/Scenes/Scena podsumowania.unity", LoadSceneMode.Additive);

    }
}