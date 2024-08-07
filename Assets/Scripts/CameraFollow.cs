using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    private float smoothSpeed = 0.125f;

    void FixedUpdate()
    {
        offset.x = 0;
        offset.y = 6;
        offset.z = 13;

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
        transform.LookAt(player);

        Quaternion desiredRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed);
    }
}
