using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManagement sceneManager = FindObjectOfType<SceneManagement>();
        if (sceneManager != null)
        {
            sceneManager.LoadSameLevel();
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
