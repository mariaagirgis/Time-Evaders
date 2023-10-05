using UnityEngine;

public class MovingObject : MonoBehaviour
{
    // The default speed of this object
    public float speed = 5f;

    // The current speed multiplier applied to this object
    private float speedMultiplier = 1f;

    // This method returns the current speed of this object, taking into account the speed multiplier
    public float GetSpeed()
    {
        return speed * speedMultiplier;
    }

    // This method sets the speed multiplier for this object
    public void SetSpeedMultiplier(float multiplier)
    {
        speedMultiplier = multiplier;
    }

    // This method resets the speed multiplier for this object to 1
    public void ResetSpeedMultiplier()
    {
        speedMultiplier = 1f;
    }
}

