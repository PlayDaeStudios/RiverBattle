﻿using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    public float Speed = 5f;
    private float moveX = 0f;
    private float moveY = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * Speed, moveY * Speed);
    }
}
