using UnityEngine;
using UnityEngine.UI; // Needed for UI elements if interacting with them, though not strictly for quitting

public class QuitGameScript : MonoBehaviour
{
    // This function will be called by the UI Button
    public void QuitGame()
    {
        // For built games (Android, iOS, PC, etc.)
        Application.Quit();

        // For the Unity Editor (stops play mode)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
