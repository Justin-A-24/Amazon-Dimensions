using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    public Rigidbody rb;
    private Vector3 moveVelocity;

    public bool isMoving;

    public Animation playerAnimation;
    public Animator animator;

    void start()
    {
        //rb = GetComponent<Rigidbody2D>();
        isMoving = false;
    }

    private void Update()
    {
        //Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"),0);
        Vector3 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
        moveVelocity = moveInput.normalized * speed;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            isMoving = true;
            playerAnimation.gameObject.GetComponent<Animator>().enabled = true;
            
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMoving = true;
            playerAnimation.gameObject.GetComponent<Animator>().enabled = true;
        }

        else
        {
            isMoving = false;
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (moveVelocity * Time.fixedDeltaTime));
    }
}