using UnityEngine;

public class SecondPlayerExp : MonoBehaviour
{
    public int SPexp;
    public GameObject FPWeapon;
    void Start()
    {
        Debug.Log(SPexp);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == FPWeapon)
        {
            SPexp++;
            Debug.Log(SPexp);
        }
    }
    private void Update()
    {
        if (SPexp == 10)
        {
            Debug.Log("you won");
        }
    }
}
