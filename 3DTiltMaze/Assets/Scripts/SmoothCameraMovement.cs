using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraMovement : MonoBehaviour
{
    public Transform target;            // The target to follow (assign your character's Transform here)
    public float smoothSpeed = 0.125f;   // The speed at which the camera follows the target
    public Vector3 offset;              // Offset to maintain between the camera and the target

    void LateUpdate()
    {
        if (target != null)
        {
                // Calculate the desired position for the camera
            Vector3 desiredPosition = target.position + offset;

                // Smoothly interpolate between the current position and the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

                // Set the position of the camera
            transform.position = smoothedPosition;

                // Make the camera look at the target
            transform.LookAt(target);
        }
        else
        {
            Debug.LogWarning("Camera target is not assigned. Please assign the target in the Unity Editor.");
        }
    }
}
