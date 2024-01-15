using UnityEngine;

public class HeartbeatPulse : MonoBehaviour
{
    [Tooltip("Maximum scale of the fish.")]
    public float maxScale = 1.2f;

    [Tooltip("Minimum scale of the fish.")]
    public float minScale = 0.8f;

    [Tooltip("Speed of the scale pulse.")]
    public float pulseSpeed = 2f;

    private Vector3 originalScale;
    private float currentPulseTime;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        // Pulse the scale of the fish up and down over time
        currentPulseTime += pulseSpeed * Time.deltaTime;

        // Calculate a scale factor with a sinusoidal pattern
        float scaleFactor = (maxScale - minScale) * (Mathf.Sin(currentPulseTime) * 0.5f + 0.5f) + minScale;

        // Apply the scale factor to the fish's original scale
        transform.localScale = originalScale * scaleFactor;
    }
}
