using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class IntroNextTurn : MonoBehaviour
{
   
    VideoPlayer m_VideoPlayer;
    
    void Awake()
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_VideoPlayer.loopPointReached += OnMovieFinished;
    }

    // Update is called once per frame
   void OnMovieFinished(VideoPlayer player)
    {
        Debug.Log("Event for movie end called");

        StartCoroutine(ExecuteAfterTime());
    }

    IEnumerator ExecuteAfterTime(float time = 3f)
    {
        yield return new WaitForSeconds(time);

            Application.LoadLevel(1);
    }

}
