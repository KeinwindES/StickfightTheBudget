using UnityEngine;
using UnityEngine.InputSystem; // Add this

public class SecondPlayerMove: MonoBehaviour
{
    public float speed;
    private float move;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Use the new Input System
        move = 0f;
        if (Keyboard.current.wKey.isPressed) move -= 1f;
        if (Keyboard.current.sKey.isPressed) move += 1f; 

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    }
}