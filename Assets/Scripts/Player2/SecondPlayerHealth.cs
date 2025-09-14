using UnityEngine;

public class SecondPlayerHealth : MonoBehaviour
{
    public int SPHP;
    public GameObject FPWeapon;
    public GameObject SPPlayer;
    
    void Start()
    {
        Debug.Log(SPHP);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == FPWeapon)
        {
            SPHP--;
            Debug.Log(SPHP);
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