using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // To reload the scene for game over
using UnityEngine;

public class RoomTriggerHandler : MonoBehaviour
{
    public string correctRoomTag = "CorrectRoom"; // Tag for the correct room
    public string gameOverSceneName = "GameOver"; // Name of the game over scene

    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Triggered with " + other.tag);
        if (other.CompareTag("Wall_Correct"))
        {
            Debug.Log("Entered the correct room!");
        }

        else if (other.CompareTag("Wall_Wrong"))
        {
            Debug.Log("Entered the wrong room!");

            // Call the GameOver function to handle the game over logic
            GameOver();
            //Application.Quit();
        }

    }

    void GameOver()
    {
        // Reload the scene or load a game over scene
        SceneManager.LoadScene(gameOverSceneName);
    }
}