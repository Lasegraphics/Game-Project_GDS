using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivation : MonoBehaviour
{
    private bool onTheGround;

    public LayerMask layersToTest;
    public Transform groundTester;

    private float radius = 0.000001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    onTheGround = Physics2D.OverlapCircle(groundTester.position, radius, layersToTest);

    if (onTheGround)
    {

        Destroy(this.gameObject);

    }

    }
}
