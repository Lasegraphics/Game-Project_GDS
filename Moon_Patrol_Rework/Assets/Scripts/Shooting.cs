using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    public float horizontalBulletSpeed;
    //[SerializeField] GameObject VerticalBulletPrefab;
    //public float VerticalBulletSpeed;
    public float HorizontalTime;
    //public float VerticalTime;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootHorizontalBullet();
            //ShootVerticalBullet();    
        }

    }

    void ShootHorizontalBullet()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab);
        bullet.transform.position = new Vector3 (transform.position.x, transform.position.y + .3f, transform.position.z);
        bullet.transform.SetParent(null);
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalBulletSpeed, 0f), ForceMode2D.Force);
        Destroy(bullet, HorizontalTime);
    }

    /*
    void ShootVerticalBullet()
    {
        GameObject VerticalBullet = Instantiate(VerticalBulletPrefab, gameObject.transform);
        VerticalBullet.transform.SetParent(null);
        VerticalBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(170f, VerticalBulletSpeed), ForceMode2D.Force);
        Destroy(VerticalBullet, VerticalTime);
    }*/
}
