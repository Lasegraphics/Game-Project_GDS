﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_stones : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}