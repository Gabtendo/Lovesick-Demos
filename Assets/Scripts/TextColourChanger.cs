using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColorChanger : MonoBehaviour
{
    // Reference to the Text component
    public Text textComponent;

    // Function to change the color of the text
    public void ChangeTextColor(Color color)
    {
        // Check if the text component reference is not null
        if (textComponent != null)
        {
            // Change the color of the text
            textComponent.color = color;
        }
        else
        {
            Debug.LogError("Text component reference is not set!");
        }
    }

    // This method is called when the script instance is being loaded
    private void Start()
    {
        // Change text color to red when the scene starts
        ChangeTextColor(Color.red);
    }
}
