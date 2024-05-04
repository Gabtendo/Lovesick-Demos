using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float scaleFactor = 1.2f; // The scale factor to apply when hovering over the button
    public float transitionDuration = 0.2f; // The duration of the scaling transition
    public AudioClip hoverSound; // Sound to play when hovering over the button

    private Vector3 originalScale; // The original scale of the button
    private bool isHovering = false; // Flag to track whether the mouse is currently hovering over the button
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Store the original scale of the button
        originalScale = transform.localScale;

        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // The mouse pointer has entered the button area
        isHovering = true;
        ScaleButton(scaleFactor);
        PlayHoverSound();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // The mouse pointer has exited the button area
        isHovering = false;
        ScaleButton(1.0f); // Restore to original scale
    }

    void Update()
    {
        // If the mouse is not hovering over the button, smoothly transition back to the original scale
        if (!isHovering)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, originalScale, Time.deltaTime / transitionDuration);
        }
    }

    private void ScaleButton(float targetScale)
    {
        // Smoothly scale the button to the target scale
        transform.localScale = Vector3.Lerp(transform.localScale, originalScale * targetScale, Time.deltaTime / transitionDuration);
    }

    private void PlayHoverSound()
    {
        // Play the hover sound if it is assigned and the AudioSource component is valid
        if (hoverSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(hoverSound);
        }
    }
}