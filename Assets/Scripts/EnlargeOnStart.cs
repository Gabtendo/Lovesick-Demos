using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeOnStart : MonoBehaviour
{
    public float scaleFactor = 30f; // Change this value to adjust the scale factor

    void Start()
    {
        // Double the scale of the object on all axes
        transform.localScale *= scaleFactor;
    }
}
