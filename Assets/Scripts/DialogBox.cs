using Unity.VisualScripting;
using UnityEngine;

public class DialogBox : MonoBehaviour
{
    //shows dialog box in trigger zone
    public GameObject dialogBox;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            dialogBox.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            dialogBox.SetActive(false);
        }
    }

}
