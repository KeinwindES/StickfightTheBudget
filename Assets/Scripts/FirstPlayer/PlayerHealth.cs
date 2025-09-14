using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int FPHP;
    public GameObject SPWeapon;
    public GameObject FPPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(FPHP);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == SPWeapon)
        {
            FPHP--;
        }

    }
    private void Update()
    {
        if (FPHP <= 0)
        {
            Destroy(FPPlayer);
        }
    }
}
