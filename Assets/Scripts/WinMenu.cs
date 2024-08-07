using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Runtime.CompilerServices;

public class WinMenu : MonoBehaviour
{
    public void ContinueGame()
    {
        SceneManagement sceneManager = FindObjectOfType<SceneManagement>();

        if (sceneManager != null)
        {
            sceneManager.LoadNextLevel();
        }

        else
        {
            Debug.LogError("Scene not found!");
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
