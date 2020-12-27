using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject car;
    public float smooth; 
    public Vector3 currVelocity;

    void Update()
    {
        Vector3 newCamPosition = new Vector3 (car.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, newCamPosition, ref currVelocity, smooth);
    }
}
