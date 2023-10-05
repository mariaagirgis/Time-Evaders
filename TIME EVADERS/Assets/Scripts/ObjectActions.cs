using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Lean.Touch;


public class ObjectActions : MonoBehaviour
{
    public GameObject tm;
    public GameObject healthBar;
    public GameObject yearsupdater;
    public TextMeshProUGUI yearstraveled;
    public AudioSource goldSound; 

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<LeanSelectableByFinger>().Deselect();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<LeanSelectableByFinger>().Deselect();

    }

    public void Destroy(LeanFinger finger)
    {
        if (this.gameObject.tag == "watch")
        {
            Object.Destroy(gameObject);
            tm.GetComponent<SoundManager>().TapTime();
            healthBar.GetComponent<HealthScript>().lives--;
            healthBar.GetComponent<HealthScript>().loseHearts();
        }
        else if (this.gameObject.tag == "enemy")
        {
            Object.Destroy(gameObject);
            Vector3 location = transform.position;
            tm.GetComponent<SoundManager>().TapEnemy(location);

        }
        else if (this.gameObject.tag == "goldball")
        {
            Object.Destroy(gameObject);
            yearsupdater.GetComponent<yearsint>().yearstraveledint += 200;
            tm.GetComponent<SoundManager>().TapGoldBall();


            //goldSound.Play(); 
            //play sound
        }
        else if (this.gameObject.tag == "boss")
        {
            Object.Destroy(gameObject);
            Vector3 location = transform.position;
            tm.GetComponent<SoundManager>().TapBoss(location);
        }

    }

}
