using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    public float horizontalBulletSpeed;
    public float HorizontalTime;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ShootHorizontalBullet();   
        }
    }

    void ShootHorizontalBullet()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab);
        bullet.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        bullet.transform.SetParent(null);
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalBulletSpeed, 0f), ForceMode2D.Force);
        Destroy(bullet, HorizontalTime);
    }
}
