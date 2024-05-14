using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPosition : MonoBehaviour
{
    // Target position to rotate towards
    public Vector3 targetPosition;

    // Rotation speed
    public float rotationSpeed = 90f; // Degrees per second

    // Flag to track if rotation is complete
    private bool rotationComplete = false;

    // Update is called once per frame
    void Update()
    {
        if (!rotationComplete)
        {
            // Calculate the direction to the target position
            Vector3 direction = targetPosition - transform.position;

            // Ensure the direction isn't zero to avoid errors
            if (direction != Vector3.zero)
            {
                // Calculate the rotation to face the target position
                Quaternion targetRotation = Quaternion.LookRotation(direction);

                // Calculate the angle between the current rotation and the target rotation
                float angle = Quaternion.Angle(transform.rotation, targetRotation);

                // Calculate the rotation step
                float step = rotationSpeed * Time.deltaTime;

                // Rotate towards the target rotation
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, step);

                // Check if the angle is approximately zero, indicating that the rotation is complete
                if (Mathf.Approximately(angle, 0f))
                {
                    rotationComplete = true;
                }
            }
        }
    }
}





