using UnityEngine;

public class VisibilityToggle : MonoBehaviour
{
    [Tooltip("The key to press to toggle visibility.")]
    public KeyCode toggleKey = KeyCode.H; // Set this to whatever key you want to use to hide/show the fish

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Get the SpriteRenderer component from the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player presses the toggle key
        if (Input.GetKeyDown(toggleKey))
        {
            // Toggle the visibility of the sprite
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
    }
}
