using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class ChangeToMultiPlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Switching to Multiplayer");
            SceneManager.LoadScene("Assets/Scenes/Multplayer.unity");
        }
    }
}
