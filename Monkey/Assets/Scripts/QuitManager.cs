using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitApplication()
    {
        // This logs a message so you know it's working while testing in the editor
        Debug.Log("Quit button pressed!");

        // This closes the actual built application
        Application.Quit();

        // This stops the play mode if you are running inside the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    void Update()
    {
        // Optional: Quit when the 'Escape' key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitApplication();
        }
    }
}