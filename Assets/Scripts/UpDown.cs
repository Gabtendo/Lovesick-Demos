using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float speed = 1.0f;         // Speed of the movement
    public float height = 0.5f;        // Maximum height of the movement

    private Vector3 startPos;

    void Start()
    {
        // Store the starting position of the GameObject
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new position
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}