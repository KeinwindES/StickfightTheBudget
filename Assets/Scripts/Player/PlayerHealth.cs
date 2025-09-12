using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int HP;
    public GameObject NPC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(HP);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == NPC)
        {
            HP--;
            Debug.Log(HP);
        }
    }
}
