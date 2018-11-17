using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    public Rigidbody rb;
    private Vector3 moveVelocity;

    void start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"),0);
        Vector3 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (moveVelocity * Time.fixedDeltaTime));
    }
}