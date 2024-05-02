using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement1 : MonoBehaviour
{
    public Transform rotationPoint; // The point around which the camera rotates
    public float rotationSpeed = 5f; // The speed of camera rotation

    void Update()
    {
        // Rotate camera continuously around the rotation point
        transform.RotateAround(rotationPoint.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
