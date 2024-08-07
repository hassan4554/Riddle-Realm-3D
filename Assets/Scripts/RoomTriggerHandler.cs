using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RoomTriggerHandler : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        SceneManagement sceneManager = FindObjectOfType<SceneManagement>();

        if (other.CompareTag("Win"))
        {
            int nextLevel = sceneManager.GetCurrentLevel() + 1;
            Debug.Log("Next Level: " + nextLevel);
            PlayerPrefs.SetInt("LastCompletedLevel", nextLevel);
            PlayerPrefs.Save();

            SceneManager.LoadScene("WinScene");
        }

        else if (other.CompareTag("Wall_Correct"))
        {
            Debug.Log("Entered the correct room!");
        }

        else if (other.CompareTag("Wall_Wrong"))
        {
            int nextLevel = sceneManager.GetCurrentLevel();
            Debug.Log("Next Level: " + nextLevel);
            PlayerPrefs.SetInt("LastCompletedLevel", nextLevel);
            PlayerPrefs.Save();

            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}