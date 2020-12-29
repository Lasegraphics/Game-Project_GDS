using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChanger : MonoBehaviour
{

    public GameObject toChange;
    // Start is called before the first frame update
    void Start()
    {
        

        Invoke("ChangePos", 2.0f);

    }

    // Update is called once per frame
   public void ChangePos()
   {

        toChange.transform.position = new Vector2(transform.position.x + 10f,transform.position.y);

   }
}
