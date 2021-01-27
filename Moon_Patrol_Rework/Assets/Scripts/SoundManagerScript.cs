using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip jumpSound, shoot, kill, destroy, point; 
    static AudioSource audiosrc;  
    
    void Start()
    {
        //background = Resources.Load<AudioClip>("02_Muzyka_w_tle");
        jumpSound  = Resources.Load<AudioClip>("jump");
        shoot  = Resources.Load<AudioClip>("shoot");
        kill  = Resources.Load<AudioClip>("kill");
        destroy  = Resources.Load<AudioClip>("destroy");
        point  = Resources.Load<AudioClip>("point");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {

            //case "background":

             //   audiosrc.PlayOneShot(background);
               // break;

            case "jump":

                audiosrc.PlayOneShot(jumpSound);
                break;

            case "shoot":

                audiosrc.PlayOneShot(shoot);
                break;

            case "kill":
                audiosrc.PlayOneShot(kill);
                break;

            case "destroy":
                audiosrc.PlayOneShot(destroy);
                break;

            case "point":
                audiosrc.PlayOneShot(point);
                break;


        }





    }
}
