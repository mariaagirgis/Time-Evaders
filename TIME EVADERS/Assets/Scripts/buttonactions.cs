using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonactions : MonoBehaviour
{
    public GameObject heartbutton;
    public GameObject healthBar;
    public TextMeshProUGUI yearstraveled;
    public GameObject yearsupdater;
    public GameObject SLOMO;
    public TextMeshProUGUI heartcountertext;
    public int heartcounter = 10;

    // Start is called before the first frame update
    void Start()
    {
        heartbutton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void heartbuttonaction()
    {
        // Access the yearsint script attached to the yearsupdater game object
        yearsint yearsUpdaterScript = yearsupdater.GetComponent<yearsint>();

        // Check if yearstraveledint is greater than or equal to 300
        if (yearsUpdaterScript.yearstraveledint >= 300)
        {
            // If it is, decrement yearstraveledint by 150
            yearsUpdaterScript.yearstraveledint -= 300;
            healthBar.GetComponent<HealthScript>().lives++;
            heartcounter--;
            heartcountertext.text = (heartcounter.ToString() + " Remaining");
            if (heartcounter == 0)
            {
                heartbutton.SetActive(false);
            }
        }
    }

    public void freezebuttonaction(){

        yearsint yearsUpdaterScript = yearsupdater.GetComponent<yearsint>();

        if (yearsUpdaterScript.yearstraveledint>=600){

            yearsUpdaterScript.yearstraveledint-=600;
            ICECUBE sn= SLOMO.GetComponent<ICECUBE>();
            sn.start();
        }
    } 
}


