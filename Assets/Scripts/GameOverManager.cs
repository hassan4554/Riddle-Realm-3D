using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public void RestartGame()
    {
        //Assuming the main game scene is called "MainScene"
        Debug.Log("Restart Game!");
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        //Quits the application
        Debug.Log("Exiting...!");
        Application.Quit();
    }
}
