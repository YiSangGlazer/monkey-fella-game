using UnityEngine;
using UnityEngine.SceneManagement; // Required for switching scenes

public class SceneChanger : MonoBehaviour
{
    // This function can be called by a UI Button
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}