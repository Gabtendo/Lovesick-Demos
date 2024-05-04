using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f; // Adjust this value to change the rotation speed

    void Start()
    {
        StartRotation(); // Start rotating the skybox when the scene starts
    }

    void Update()
    {
        // Rotate the skybox continuously
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }

    public void StartRotation()
    {
        enabled = true; // Enable the script to start rotating the skybox
    }

    public void StopRotation()
    {
        enabled = false; // Disable the script to stop rotating the skybox
    }
}