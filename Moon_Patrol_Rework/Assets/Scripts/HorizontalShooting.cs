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
            SoundManagerScript.PlaySound("shoot");
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
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Points100")
        {
            Destroy(gameObject);
        }
    }
}
