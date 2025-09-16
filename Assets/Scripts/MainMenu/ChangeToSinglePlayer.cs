using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Quit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Comming Soon");
        }
    }
}
