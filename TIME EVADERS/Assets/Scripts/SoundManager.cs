using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public bool playEnemySound = false;
    public GameObject Enemy;
    public AudioClip ac;
    public AudioSource aSource;
    public GameObject Explosion;
    public GameObject NukeExplosion;

    
    //public AudioSource bSource;
    public bool playSound=false;
    public bool playGold = false;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3; 

    

    // Start is called before the first frame update
    void Start()
    {
        //Getting audio sources for sound affecs 
        aSource = GetComponent<AudioSource>();
        //bSource= GetComponent<AudioSource>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playEnemySound == true)
        {
            playEnemySound = false;
        }
        if (playSound==true){
            playSound=false; 
        }
        if (playGold == true) {
            playGold = false;
        }
    }

    public void TapEnemy(Vector3 location) //called when Enemy is tapped, code in ObjectActions of Enemy
    {
        //Calling audio source A to plau when Destoryed 
        //working 
        Instantiate(Explosion, location, Quaternion.identity);
        aSource.PlayOneShot(clip1);
        Debug.Log("Play enemy tap sound");
    }

    public void TapTime(){
        //Calling audio source B to play when Destroyed 
        //Not working
        aSource.PlayOneShot(clip3); 
        Debug.Log("Sound played?");
    }

    public void TapBoss(Vector3 location)
    {
        Instantiate(NukeExplosion, location, Quaternion.identity);
    }

    public void TapGoldBall() {

        aSource.PlayOneShot(clip3);
    }

}
