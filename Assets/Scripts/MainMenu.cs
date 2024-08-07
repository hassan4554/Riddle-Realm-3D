using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void OnContinueButtonPressed()
    {
        if (PlayerPrefs.HasKey("LastCompletedLevel"))
        {
            int lastCompletedLevel = PlayerPrefs.GetInt("LastCompletedLevel");
            SceneManager.LoadScene(lastCompletedLevel);
        }
        else
        {
            StartGame();
        }
    }


    public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

