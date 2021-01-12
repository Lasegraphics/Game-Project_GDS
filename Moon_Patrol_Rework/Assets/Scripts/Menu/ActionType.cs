using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ActionType : MonoBehaviour
{
    // Start is called before the first frame update


    public void SelectScene()
    {

        SceneManager.LoadScene("A-E");

    }


        public void ExitApp()
    {

        Application.Quit();

    }

}
