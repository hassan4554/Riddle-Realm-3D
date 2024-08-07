using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float speed = 10f;
    private float HorizontalInput;
    private float VerticalInput;

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(-Vector3.forward * Time.deltaTime * VerticalInput * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * HorizontalInput * 40);
    }
}
