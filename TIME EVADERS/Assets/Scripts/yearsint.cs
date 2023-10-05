using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class yearsint : MonoBehaviour
{
    public TextMeshProUGUI yearstraveled;
    public int yearstraveledint = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("wtf");
        yearstraveled.text = ("Years Traveled: " + yearstraveledint.ToString());
    }
}
