using System;
using UnityEngine;

public class SecondPlayerHealth : MonoBehaviour
{
    public int SPHP;
    public GameObject FPWeapon;
    public GameObject SPPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(SPHP);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == FPWeapon)
        {
            SPHP--;
        }

    }
    private void Update()
    {
        if (SPHP <= 0)
        {
            Destroy(SPPlayer);
        }
    }
}
