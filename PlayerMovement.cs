using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float horizontalMovement = 8f;
    private float jumpForce = 12f;
    private bool isFacingRight = true;

    [SerializeField]  public Rigidbody2D rb;
    [SerializeField]  public Transform groundCheck;
    [SerializeField]  public LayerMask groundLayer;
    
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce );

        }
        Flip();

        
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position , 0.2f, groundLayer);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * horizontalMovement, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }
}
