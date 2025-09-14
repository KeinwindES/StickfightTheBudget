using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
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
        move = 0f;
        if (Keyboard.current.aKey.isPressed) move -= 1f;
        if (Keyboard.current.dKey.isPressed) move += 1f;

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    }
}