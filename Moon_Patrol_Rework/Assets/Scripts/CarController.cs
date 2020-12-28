﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    private float movement;
    public float speed;
    public float basicSpeed;
    public float jumpPower;
    private bool onTheGround;
    private float radius = 0.1f;
    public Transform groundTester;
    public LayerMask layersToTest;

    void Start()
    {
        carRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        onTheGround = Physics2D.OverlapCircle(groundTester.position, radius, layersToTest);
        carRigidbody.AddForce(new Vector2 (basicSpeed, 0f));
        movement = Input.GetAxis("Horizontal");
        carRigidbody.velocity = new Vector2 (movement * speed, carRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            carRigidbody.AddForce (new Vector2(0f, jumpPower));
        }
    }
}
