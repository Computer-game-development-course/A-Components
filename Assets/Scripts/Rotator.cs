using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("Rotation speed in degrees per second")]
    [SerializeField]
    private float rotationSpeed = 90.0f;

    // Update is called once per frame
    void Update()
    {
        // Perform the rotation around the fish's local z axis, at rotationSpeed degrees per second.
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
