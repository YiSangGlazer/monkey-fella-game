using UnityEngine;

public class QuitManager : MonoBehaviour
{
    public void QuitGame()
    {
        // This line closes the application
        Application.Quit();

        // This line only works in the Unity Editor to show that the button works
        Debug.Log("Game is exiting...");
    }
}