using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class ChangeToMainMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Switching to Multiplayer");
        // Add your scene transition logic here
        SceneManager.LoadScene("Assets/Scenes/MainMenu.unity");
    }
}
