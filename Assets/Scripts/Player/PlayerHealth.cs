using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int HP;
    public GameObject Weapon;
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(HP);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Weapon)
        {
            HP--;
            Debug.Log(HP);
        }

    }
    private void Update()
    {
        if (HP <= 0)
        {
            Destroy(Player);
        }
    }
}
