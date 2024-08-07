using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveCamera3D : MonoBehaviour
{
    private Camera cam;
    private float initialFieldOfView;

    void Start()
    {
        cam = GetComponent<Camera>();
        initialFieldOfView = cam.fieldOfView;
        AdjustFieldOfView();
    }

    void Update()
    {
        AdjustFieldOfView();
    }

    void AdjustFieldOfView()
    {
        float targetAspect = 1080.0f / 1920.0f;
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        cam.fieldOfView = initialFieldOfView * scaleHeight;
    }
}
