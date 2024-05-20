using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopEnlarge : MonoBehaviour
{
    public GameObject[] objectsToScale;  // Array of objects to scale
    public Vector3 enlargedScale = new Vector3(2f, 2f, 2f);  // Scale when enlarged
    public float duration = 1f;  // Time taken to scale up and down

    private Vector3 originalScale;  // Original scale of the objects

    void Start()
    {
        if (objectsToScale.Length > 0)
        {
            originalScale = objectsToScale[0].transform.localScale;  // Assuming all objects have the same original scale
        }

        StartCoroutine(ScaleObjects());
    }

    private System.Collections.IEnumerator ScaleObjects()
    {
        while (true)
        {
            // Scale up
            yield return ScaleTo(enlargedScale);
            // Scale down
            yield return ScaleTo(originalScale);
        }
    }

    private System.Collections.IEnumerator ScaleTo(Vector3 targetScale)
    {
        float time = 0f;

        Vector3[] startScales = new Vector3[objectsToScale.Length];
        for (int i = 0; i < objectsToScale.Length; i++)
        {
            startScales[i] = objectsToScale[i].transform.localScale;
        }

        while (time < duration)
        {
            for (int i = 0; i < objectsToScale.Length; i++)
            {
                objectsToScale[i].transform.localScale = Vector3.Lerp(startScales[i], targetScale, time / duration);
            }
            time += Time.deltaTime;
            yield return null;
        }

        for (int i = 0; i < objectsToScale.Length; i++)
        {
            objectsToScale[i].transform.localScale = targetScale;
        }
    }
}