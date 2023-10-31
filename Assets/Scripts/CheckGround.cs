using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;

    void OnTriggerEnter2D(Collider2D other)
    {
        isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isGrounded = false;
    }
}
