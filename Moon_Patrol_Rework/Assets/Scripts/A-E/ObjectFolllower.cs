using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFolllower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Enemy.transform.position.x, Enemy.transform.position.y, transform.position.z);
    }
        
}
