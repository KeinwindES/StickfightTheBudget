using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    //FP = FirstPlayer
    //SP = SecondPlayer
    public int FPexp;
    public GameObject SPWeapon;
    void Start()
    {
        Debug.Log(FPexp);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == SPWeapon)
        {
            FPexp++;
            Debug.Log(FPexp);
        }

    }
    private void Update()
    {
        if (FPexp == 10)
        {
            Debug.Log("Level Up");
        }
    }
}
