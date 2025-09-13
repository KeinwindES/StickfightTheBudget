using UnityEngine;

public class SecondPlayerExp : MonoBehaviour
{
    public int exp;
    public GameObject Weapon;
    void Start()
    {
        Debug.Log(exp);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Weapon)
        {
            exp++;
            Debug.Log(exp);
        }
    }
    private void Update()
    {
        if (exp == 10)
        {
            Debug.Log("Level Up");
        }
    }
}
