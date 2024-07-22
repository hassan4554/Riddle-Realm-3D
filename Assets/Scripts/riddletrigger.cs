using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleTrigger : MonoBehaviour
{
    private string riddleText = "You can see the door with right eye closed!";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Show Riddle!");
            RiddleUI.Instance.ShowRiddle(riddleText);
        }
    }
}
