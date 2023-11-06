using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedMove;
    public float jumpingPower;
    public SpriteRenderer sprtRnd;
    public Animator animPlayer;

    private float horizontal;
    private bool isFacingRight = true;

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.checkMovement();
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }

    private void checkMovement()
    {
        if (Mathf.Abs(horizontal) != 0f)
            animPlayer.SetBool("isWalking", true);
        else
            animPlayer.SetBool("isWalking", false);

        rb.velocity = new Vector2(horizontal * speedMove, rb.velocity.y);

        if (!isFacingRight && horizontal > 0f)
        {
            isFacingRight = true;
            sprtRnd.flipX = false;
        }
        else if (isFacingRight && horizontal < 0f)
        {
            isFacingRight = false;
            sprtRnd.flipX = true;
        }
    }

    public void Jump()
    {
        if (CheckGround.isGrounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
    }
}
