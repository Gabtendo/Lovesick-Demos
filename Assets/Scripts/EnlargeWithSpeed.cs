using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeWithSpeed : MonoBehaviour
{
    public float targetScaleFactor = 2f; // The final scale factor
    public float enlargeSpeed = 1f; // Speed at which the object enlarges

    private Vector3 initialScale; // Initial scale of the object
    private bool isEnlarging = false; // Flag to track if object is currently enlarging

    void Start()
    {
        initialScale = transform.localScale; // Store the initial scale
        StartCoroutine(EnlargeOverTime());
    }

    IEnumerator EnlargeOverTime()
    {
        isEnlarging = true;
        float elapsedTime = 0f;
        while (elapsedTime < enlargeSpeed)
        {
            float t = elapsedTime / enlargeSpeed;
            transform.localScale = Vector3.Lerp(initialScale, initialScale * targetScaleFactor, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.localScale = initialScale * targetScaleFactor; // Ensure final scale is reached
        isEnlarging = false;
    }
}