using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RiddlePopupTrigger : MonoBehaviour
{
    public Animator riddleAnimator;
    private bool showRiddle = false;
    public GameObject riddle_image;

    private void Start()
    {
        Debug.Log("hidding Image");
        HideImage();
    }

    public void HideImage()
    {
        riddle_image.SetActive(false);
    }

    public void ShowImage()
    {
        riddle_image.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && !showRiddle)
        {
            showRiddle = true;
            Debug.Log("Showing Image");
            ShowImage();
            riddleAnimator.SetBool("isDisplayed", true);
        }

        //else
        //{
        //    showRiddle = false;
        //    Debug.Log("Hiding Image 2");
        //    HideImage();
        //}


    }

}
