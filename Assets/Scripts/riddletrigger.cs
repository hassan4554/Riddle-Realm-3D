using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riddletrigger : MonoBehaviour
{
    public string riddle = "What has keys but can't open locks?";
    public Text riddleText; // Assign this from the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DisplayRiddle();
        }
    }

    private void DisplayRiddle()
    {
        riddleText.text = riddle;
        riddleText.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideRiddle();
        }
    }

    private void HideRiddle()
    {
        riddleText.gameObject.SetActive(false);
    }
}
