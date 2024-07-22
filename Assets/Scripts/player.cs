using System.Collections;
using System.Collections.Generic;
//using UnityEngine.SceneManagement;
using UnityEngine;

public class player : MonoBehaviour
{
    private float speed = 10f;
    private float HorizontalInput;
    private float VerticalInput;

    public string correctRoomTag = "CorrectRoom"; // Tag for the correct room
    public string gameOverSceneName = "GameOver"; // Name of the game over scenesss
    void Start()
    {
        Debug.Log("Game Started!");
    }

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(-Vector3.forward * Time.deltaTime * VerticalInput * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * HorizontalInput * 40);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall_Correct!")
        {
            Debug.Log("Correct Room Entered!");
        }

        else
        {
            Debug.Log("Wrong Room entered!");
           // GameOver();
        }
    }

    //void GameOver()
    //{
    //    // Reload the scene or load a game over scene
    //    SceneManager.LoadScene(gameOverSceneName);
    //}
}
