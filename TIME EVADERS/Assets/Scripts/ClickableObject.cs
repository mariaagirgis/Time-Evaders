using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public float speedMultiplier = 0.5f;
    public float duration = 5.0f;

    private movement movement;

    void Start()
    {
        // Find the object with the Movement script attached
        movement = GameObject.FindObjectOfType<movement>();
    }

    void OnMouseDown()
    {
        // Double the speed variable
        movement.speed *= speedMultiplier;

        // Wait for the duration of the effect
        StartCoroutine(ResetSpeedAfterDelay(duration));
    }

    IEnumerator ResetSpeedAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Reset the speed variable to its original value
        movement.speed /= speedMultiplier;
    }
}
