using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalShooting : MonoBehaviour
{
    [SerializeField] GameObject VerticalBulletPrefab;
    public float VerticalBulletSpeed;
    public float VerticalTime;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootVerticalBullet();    
        }
    }

    void ShootVerticalBullet()
    {
        GameObject VerticalBullet = Instantiate(VerticalBulletPrefab, gameObject.transform);
        VerticalBullet.transform.SetParent(null);
        VerticalBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(170f, VerticalBulletSpeed), ForceMode2D.Force);
        Destroy(VerticalBullet, VerticalTime);
    }
}
