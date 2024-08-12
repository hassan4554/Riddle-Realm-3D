using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NotificationDrawerController : MonoBehaviour
{
    public RectTransform drawerPanel;
    public Button notificationButton;
    public Button closeButton;
    public float slideSpeed = 10f;

    private Vector2 originalPosition;
    private Vector2 hiddenPosition;
    private bool isOpen = false;

    void Start()
    {
        originalPosition = drawerPanel.anchoredPosition;
        hiddenPosition = new Vector2(originalPosition.x + drawerPanel.rect.width, originalPosition.y);

        drawerPanel.anchoredPosition = hiddenPosition;

        notificationButton.onClick.AddListener(ToggleDrawer);
        closeButton.onClick.AddListener(ToggleDrawer);
    }

    void ToggleDrawer()
    {
        isOpen = !isOpen;
        StopAllCoroutines();
        if (isOpen)
        {
            StartCoroutine(SlideDrawer(originalPosition));
            notificationButton.gameObject.SetActive(true);
        }
        else
        {
            StartCoroutine(SlideDrawer(hiddenPosition));
            notificationButton.gameObject.SetActive(false);
        }
    }

    System.Collections.IEnumerator SlideDrawer(Vector2 targetPosition)
    {
        while (Vector2.Distance(drawerPanel.anchoredPosition, targetPosition) > 0.1f)
        {
            drawerPanel.anchoredPosition = Vector2.Lerp(drawerPanel.anchoredPosition, targetPosition, slideSpeed * Time.deltaTime);
            yield return null;
        }
        drawerPanel.anchoredPosition = targetPosition;
    }
}
