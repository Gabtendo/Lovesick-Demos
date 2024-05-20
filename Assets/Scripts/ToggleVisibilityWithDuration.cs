using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVisibilityWithDuration : MonoBehaviour
{
    public GameObject targetObject;  // The GameObject to show/hide
    public Button toggleButton;  // The UI Button that will trigger the visibility
    public float visibleDuration = 2f;  // Duration for which the object will be visible

    void Start()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false);  // Make the target object invisible at the start
        }

        if (toggleButton != null)
        {
            toggleButton.onClick.AddListener(() => StartCoroutine(ShowObjectTemporarily()));  // Add a listener to the button
        }
    }

    private System.Collections.IEnumerator ShowObjectTemporarily()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true);  // Make the target object visible

            yield return new WaitForSeconds(visibleDuration);  // Wait for the specified duration

            targetObject.SetActive(false);  // Make the target object invisible again
        }
    }
}
