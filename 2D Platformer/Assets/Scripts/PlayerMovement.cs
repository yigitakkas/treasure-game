using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    public float jumpForce = 20f;
    public Transform feet;
    public Transform RArm;
    public Transform LArm;
    public LayerMask groundLayers;

    float mx;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

        if (!IsLeftTouch() && mx == -1)
        {
            Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

            rb.velocity = movement;
        }
        else if(!IsRightTouch() && mx == 1)
        {
            Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

            rb.velocity = movement;
        }
    }

    private void FixedUpdate()
    {
        

        


    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }

    public bool IsLeftTouch()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(LArm.position, 0.2f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }
    public bool IsRightTouch()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(RArm.position, 0.2f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }

    
}
