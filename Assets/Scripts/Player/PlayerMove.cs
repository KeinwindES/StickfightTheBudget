using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public int playerNumber;
    private float move;
    private Rigidbody2D rb;
    public float jumpForce = 5f;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        move = 0f;
        if (playerNumber == 1)
        {
            if (Keyboard.current.leftArrowKey.isPressed) move -= 1f;
            if (Keyboard.current.rightArrowKey.isPressed) move += 1f;
            if (Keyboard.current.upArrowKey.wasPressedThisFrame && isGrounded)
            {
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                isGrounded = false;
            }
        }
        else
        {
            if (Keyboard.current.aKey.isPressed) move -= 1f;
            if (Keyboard.current.dKey.isPressed) move += 1f;
            if (Keyboard.current.wKey.wasPressedThisFrame && isGrounded)
            {
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                isGrounded = false;
            }
        }

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    }
}