using UnityEngine;
using UnityEngine.InputSystem;

public class SecondPlayerMove : MonoBehaviour
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
        if (Keyboard.current.jKey.isPressed) move -= 1f;
        if (Keyboard.current.lKey.isPressed) move += 1f; 

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    }
}