using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public float slowDownFactor = 0.5f; // factor to slow down prefabs by

    private void OnMouseDown()
    {
        // Get all prefabs with a Rigidbody component
        Rigidbody[] prefabs = FindObjectsOfType<Rigidbody>();
        Debug.Log("hi");

        // Slow down each prefab
        foreach (Rigidbody prefab in prefabs)
        {
            prefab.velocity *= slowDownFactor;
        }
    }
}
