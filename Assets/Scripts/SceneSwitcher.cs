using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Public variable to store the name of the scene to switch to
    public string sceneToSwitchTo;

    // Update is called once per frame
    void Update()
    {
        // Check for right mouse button click
        if (Input.GetMouseButtonDown(1))
        {
            // Call a function to switch scene
            SwitchScene();
        }
    }

    void SwitchScene()
    {
        // Load the scene specified in the public variable
        SceneManager.LoadScene(sceneToSwitchTo);
    }
}