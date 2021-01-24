using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EJ_Resp : MonoBehaviour
{

    TimeCounter catcher;
    void Start()
    {

          catcher = GameObject.Find("Manager").GetComponent<TimeCounter>();

        if (catcher == null)
        {

            Debug.LogError("Cannot find TimeCounter");
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {



             Invoke("LoadSummary",1f);
             Invoke("LoadNewScene", 6f);
             catcher.ItsFinish();
             catcher.AvarageTimeAE();
             catcher.TopRecord();
             Debug.Log("Wykryto");
        
       //this.gameObject.SetActive(false);

        }
       
       
    }


    void LoadNewScene()
    {

         SceneManager.LoadScene(2);

    }

    void LoadSummary()
    {

        SceneManager.LoadScene("Assets/Scenes/Scena podsumowania.unity", LoadSceneMode.Additive);

    }
}