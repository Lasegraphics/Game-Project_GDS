using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EJ_Resp : MonoBehaviour
{
    void OnCollisionEnter2D()
    {
        SceneManager.LoadScene(1);
    }
}