using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float Speed = 15f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        rb.velocity = move * Speed;
    }
}
