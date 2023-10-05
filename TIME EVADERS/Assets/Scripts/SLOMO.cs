using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLOMO : MonoBehaviour
{
    // The time scale to set when the slow-motion effect is active
    public float slowMotionTimeScale = 0.5f;

    // The duration of the slow-motion effect in seconds
    public float slowMotionDuration = 3f;

    // A flag indicating whether the slow-motion effect is currently active
    private bool isActive = false;

    // This method is called when the player clicks on the power-up object
    private void OnMouseDown()
    {
        Debug.Log("triggered");
        // Only activate the slow-motion effect if it's not already active
        if (!isActive)
        {
            StartCoroutine(SlowMotionCoroutine());
        }
    }

    // This coroutine implements the slow-motion effect
    private IEnumerator SlowMotionCoroutine()
    {
        // Set the isActive flag to true to prevent the player from activating the effect multiple times in a row
        isActive = true;

        // Set the time scale to the slow-motion value
        Time.timeScale = slowMotionTimeScale;

        // Wait for the specified duration before returning the time scale to normal
        yield return new WaitForSecondsRealtime(slowMotionDuration);

        // Set the time scale back to normal
        Time.timeScale = 1f;

        // Set the isActive flag back to false to allow the player to activate the effect again
        isActive = false;
    }
}
