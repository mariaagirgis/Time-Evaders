using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public AudioSource audios;

    public void playButton(){
        audios.Play(); 
    }
}
