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
        if (Input.GetKeyDown(KeyCode.C))
        {
            ShootVerticalBullet();    
        }
    }

    void ShootVerticalBullet()
    {
        GameObject VerticalBullet = Instantiate(VerticalBulletPrefab, gameObject.transform);
        VerticalBullet.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        VerticalBullet.transform.SetParent(null);
        VerticalBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(350f, VerticalBulletSpeed), ForceMode2D.Force);
        VerticalBullet.GetComponent<BoxCollider2D>();
        Destroy(VerticalBullet, VerticalTime);
    }
}
