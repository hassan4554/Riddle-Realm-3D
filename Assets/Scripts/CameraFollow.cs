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
        offset.z = 16;

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        transform.position = smoothedPosition;
        transform.LookAt(player);

        Quaternion desiredRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed);
    }
}
