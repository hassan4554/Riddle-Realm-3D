using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    private Vector3 offset;   // Offset distance between the player and camera
    private float smoothSpeed = 0.125f; // Smoothness of the camera movement

    void FixedUpdate()
    {
        offset.x = 0;
        offset.y = 6;
        offset.z = 12;

        //offset.x = 0;
        //offset.y = 0;
        //offset.z = 0;

        // Desired position of the camera
        Vector3 desiredPosition = player.position + offset;
        //Debug.Log("Desired Position: " +  desiredPosition);

        // Smoothly interpolate between the camera's current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //Debug.Log("Smoothed Position: " + smoothedPosition);

        // Apply the smoothed position to the camera
        transform.position = smoothedPosition;
        transform.LookAt(player);
        Quaternion desiredRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed);
    }
}
