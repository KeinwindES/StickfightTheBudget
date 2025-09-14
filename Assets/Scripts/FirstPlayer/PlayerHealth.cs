using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int FPHP;
    public GameObject SPWeapon;
    public GameObject FPPlayer;
    
    void Start()
    {
        Debug.Log(FPHP);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == SPWeapon)
        {
            FPHP--;
            Debug.Log(FPHP);
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