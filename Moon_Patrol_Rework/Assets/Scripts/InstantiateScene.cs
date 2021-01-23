using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScene : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] GameObject SceneAsset;
    void Start()
    {
        
        GameObject scene = (GameObject)Instantiate(SceneAsset);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
