﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyEvents : MonoBehaviour
{
    [SerializeField]
    [Header("RigidBody")]
     Rigidbody2D rb;
    [SerializeField]
    [Header("Speeds")]
    private float[] speeds;


    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
    }

    public void MoveLeft()
    {
        
        rb.AddForce(new Vector2(-0.2f, 0), ForceMode2D.Impulse);
        if (rb.velocity.x < -6) { rb.velocity = new Vector2(-6, rb.velocity.y); }
        rb.velocity.Normalize();
    }
    public void MoveRight()
    {
        rb.AddForce(new Vector2(0.2f, 0), ForceMode2D.Impulse);
        if (rb.velocity.x > 6) { rb.velocity = new Vector2(6, rb.velocity.y); }
        rb.velocity.Normalize();
    }
    public void MoveUp()
    {
        rb.AddForce(new Vector2(0, 0.2f), ForceMode2D.Impulse);
        if (rb.velocity.y > 6) { rb.velocity = new Vector2(rb.velocity.x, 6.0f); }
        rb.velocity.Normalize();
    }
    public void MoveDown()
    {
        rb.AddForce(new Vector2(0, -0.2f), ForceMode2D.Impulse);
        if (rb.velocity.y < -6) { rb.velocity = new Vector2(rb.velocity.x, -6.0f); }
        rb.velocity.Normalize();
    }
    public void ZeroStop()
    {
        if (!Input.anyKey)
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
