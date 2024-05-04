using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust this value to change the rotation speed
    private bool isRotating = false;

    void Start()
    {
        StartRotation();
    }

    void Update()
    {
        if (isRotating)
        {
            // Rotate the map continuously
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    public void StartRotation()
    {
        isRotating = true;
    }

    public void StopRotation()
    {
        isRotating = false;
    }
}