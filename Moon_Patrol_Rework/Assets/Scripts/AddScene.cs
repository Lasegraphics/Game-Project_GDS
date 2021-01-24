using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Assets/Scenes/Canvas.unity", LoadSceneMode.Additive);
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
