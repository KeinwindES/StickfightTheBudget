using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class ChangeToSinglePlayer : MonoBehaviour
{
    // Update is called once per frame
    public void SwitchScene()
    {
        SceneManager.LoadScene("Assets/Scenes/W1/Lvl1.unity");
    }
}
