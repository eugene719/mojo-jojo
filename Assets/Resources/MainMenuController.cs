using UnityEngine;
using UnityEngine.SceneManagement; // Required for changing scenes

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        // Replace "GameScene" with the exact name of your next level/scene
        SceneManager.LoadScene("GameScene");

        // Just for testing in the console
        Debug.Log("Game is starting...");
    }
}