using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("Rotation speed, in degrees per second")]
    [SerializeField]
    private float rotationSpeed = 80.0f;

    // Get the Transform component of the current fish
    private Transform fishTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Output to the console
        Debug.Log("Start");

        // Get the Transform component of the current fish
        fishTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Output to the console
        Debug.Log("Update");

        // Perform the rotation around the fish's local z axis
        fishTransform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
