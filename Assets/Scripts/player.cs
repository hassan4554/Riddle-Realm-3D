using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float speed = 10f;
    private float HorizontalInput;
    private float VerticalInput;
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
        if (other.gameObject.tag == "Wall1")
        {
            Debug.Log("New Room Entered!");
        }

        else
        {
            Debug.Log("room not entered");
        }
    }
}
