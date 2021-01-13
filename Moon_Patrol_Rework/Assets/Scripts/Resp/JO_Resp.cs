using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JO_Resp : MonoBehaviour
{
    void OnCollisionEnter2D()
    {
        SceneManager.LoadScene(2);
    }
}