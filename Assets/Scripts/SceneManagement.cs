using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    private static SceneManagement instance;
    private static int currentLevelIndex = 3;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadNextLevel()
    {
        currentLevelIndex++;

        if (currentLevelIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentLevelIndex);
        }
        else
        {
            Debug.LogError("No Next Level!");
        }
    }

    public int GetCurrentLevel()
    {
        return currentLevelIndex;
    }

    public void LoadSameLevel()
    {
        SceneManager.LoadScene(currentLevelIndex);
    }

    public void RestartGame()
    {
        currentLevelIndex = 3;
        SceneManager.LoadScene(currentLevelIndex);
    }
}

