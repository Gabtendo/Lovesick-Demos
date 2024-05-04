using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicSwitcher : MonoBehaviour
{
    public AudioClip newMusic; // Assign the new music clip in the Inspector

    private AudioSource audioSource;

    void Start()
    {
        // Find the existing SoundManager in the scene
        GameObject soundManagerObj = GameObject.FindWithTag("SoundManager");
        if (soundManagerObj != null)
        {
            // Get the AudioSource component from the SoundManager
            audioSource = soundManagerObj.GetComponent<AudioSource>();
            if (audioSource != null && newMusic != null)
            {
                // Check if the scene has been changed
                SceneManager.activeSceneChanged += OnSceneChanged;
            }
        }
    }

    void OnDestroy()
    {
        // Unsubscribe from the scene changed event
        SceneManager.activeSceneChanged -= OnSceneChanged;
    }

    void OnSceneChanged(Scene previousScene, Scene newScene)
    {
        // Stop the audio when scene changes
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        // Play the new music if available
        if (newMusic != null)
        {
            audioSource.clip = newMusic;
            audioSource.Play();
        }
    }
}