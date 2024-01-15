using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("The center point of the oscillation, relative to the starting position.")]
    [SerializeField]
    private Vector3 center;

    [Tooltip("The maximum distance the fish moves from the center point.")]
    [SerializeField]
    private float maxDistance = 2.0f;

    [Tooltip("How fast the fish oscillates (frequency).")]
    [SerializeField]
    private float velocity = 1.0f;

    private Vector3 direction = new Vector3(1, 0, 0);
    private Transform fishTransform;
    private float previousSinWave;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        fishTransform = GetComponent<Transform>();
        center = fishTransform.position;
        previousSinWave = Mathf.Sin(Time.time * velocity);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        float cycle = Time.time * velocity;
        float sinWave = Mathf.Sin(cycle); // This will give a value between -1 and 1

        // Flip the fish image based on the direction of the movement
        if (sinWave < previousSinWave && fishTransform.localScale.x > 0 ||
            sinWave > previousSinWave && fishTransform.localScale.x < 0)
        {
            fishTransform.localScale = new Vector3(-fishTransform.localScale.x, fishTransform.localScale.y, fishTransform.localScale.z);
        }

        previousSinWave = sinWave; // Update the previousSinWave value for the next frame

        // Determine the distance to move for this frame
        float moveStep = sinWave * maxDistance;

        // Calculate the new position based on the oscillation
        Vector3 offset = moveStep * direction.normalized;
        fishTransform.position = center + offset;
    }
}