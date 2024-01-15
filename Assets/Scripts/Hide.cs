using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    [Tooltip("The key to press to hide/show the fish.")]
    public KeyCode pressIt = KeyCode.H;

    // Get the SpriteRenderer component from the fish
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Output to the console
        Debug.Log("Start");

        // Get the SpriteRenderer component from the fish
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Output to the console
        Debug.Log("Update");

        // Check if the player presses the key
        if (Input.GetKeyDown(pressIt))
        {
            // Hide/Show the visibility of the fish
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
    }
}
