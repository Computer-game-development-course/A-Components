using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beats : MonoBehaviour
{
    [Tooltip("Maximum scale of the fish.")]
    public float maxScale = 1.3f;

    [Tooltip("Minimum scale of the fish.")]
    public float minScale = 0.7f;

    [Tooltip("Speed of the pulses.")]
    public float pulseSpeed = 3f;

    // Get the Transform component of the current fish
    private Transform fishTransform;

    private Vector3 originalScale;
    private float currentPulseTime;
    private float range = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Output to the console
        Debug.Log("Start");

        // Get the Transform component of the current fish
        fishTransform = GetComponent<Transform>();

        // Get the localScale component from the fish
        originalScale = fishTransform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        // Output to the console
        Debug.Log("Update");

        // Increase currentPulseTime by the product of pulseSpeed and Time.deltaTime each frame   
        // Time.deltaTime represents the time that has passed since the last frame
        currentPulseTime += pulseSpeed * Time.deltaTime;

        // Calculate the scale factor for the pulsing effect:
        // Mathf.Sin(currentPulseTime) creates a wave pattern that oscillates between -1 and 1
        // Multiplying it by range and adding range adjusts the wave to oscillate between 0 and 1 instead
        // (maxScale - minScale) scales the wave to the desired size range
        // Adding minScale offsets the wave so that it oscillates between minScale and maxScale 
        float scaleFactor = (maxScale - minScale) * (Mathf.Sin(currentPulseTime) * range + range) + minScale;

        // Apply the scale factor to the fish's original scale(its normal size):
        // Multiplying the original scale by the scaleFactor makes the fish grow and shrink
        fishTransform.localScale = originalScale * scaleFactor;
    }
}
