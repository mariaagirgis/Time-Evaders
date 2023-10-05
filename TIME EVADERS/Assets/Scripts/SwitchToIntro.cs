using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToIntro : MonoBehaviour
{

    public void LoadGame()
    {
        SceneManager.LoadScene(1); // Second Scene
        

    }

    public void switchMenu(){

        SceneManager.LoadScene(0); //Menu Screen

    }

    public void switchOptions(){

        SceneManager.LoadScene(3); //Options Screen

    }

    public void switchHelp(){
        SceneManager.LoadScene(4); //Help Screen
        
    }


}
