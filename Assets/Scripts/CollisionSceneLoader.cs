using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneLoader : MonoBehaviour
{
    // Specify the name of the scene you want to load
    public string sceneToLoad;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a GameObject with a specific tag
        if (collision.gameObject.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}