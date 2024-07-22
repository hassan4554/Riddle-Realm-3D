using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RiddleUI : MonoBehaviour
{
    public static RiddleUI Instance;
    public TextMeshProUGUI riddleText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowRiddle(string riddle)
    {

        Debug.Log("Riddle : " + riddle);
        riddleText.text = riddle;
        riddleText.gameObject.SetActive(true);
    }

    public void HideRiddle()
    {
        riddleText.gameObject.SetActive(false);
    }
}