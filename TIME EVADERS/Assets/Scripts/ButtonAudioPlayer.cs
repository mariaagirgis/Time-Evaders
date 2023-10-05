using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ButtonAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // Find all GameObjects with the tag "button" and attach a
        // custom function to their OnMouseDown event.
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("button");
        foreach (GameObject button in buttons)
        {
            button.AddComponent<MouseDownAudioPlayer>().audioSource = audioSource;
        }
    }

    private class MouseDownAudioPlayer : MonoBehaviour
    {
        public AudioSource audioSource;

        private void OnMouseDown()
        {
            audioSource.Play();
        }
    }
}
