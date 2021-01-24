using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EJ_Resp : MonoBehaviour
{
    void OnCollisionEnter2D()
    {
       Invoke("LoadSummary",1f);
       Invoke("LoadNewScene", 6f);
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