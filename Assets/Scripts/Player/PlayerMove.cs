using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public int playerNumber;
    private float move;
    private Rigidbody2D rb;
    public float jumpForce = 5f;
    private bool isGrounded = true;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>().x;

    }
    public void OnJump(InputAction.CallbackContext context)
    {
       

            
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    
    }
    void Update()
    {
        

        if (Keyboard.current.leftArrowKey.isPressed) move -= 1f;
        if (Keyboard.current.rightArrowKey.isPressed) move += 1f;

    
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

    }
}