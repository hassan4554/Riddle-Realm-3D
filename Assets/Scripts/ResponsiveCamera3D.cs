using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveCamera3D : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        AdjustFieldOfView();
    }

    void AdjustFieldOfView()
    {
        float targetAspect = 1080.0f / 1920.0f; // Reference aspect ratio
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        cam.fieldOfView = cam.fieldOfView * scaleHeight;
    }
}