using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICECUBE : MonoBehaviour
{
    public float slowMotionTimeScale=0.3f; 
    private float startTimeScale; 
    private float startFixedDeltaTime; 
    public float slowMotionDuration=2.0f; 
    private IEnumerator c; 
    // Start is called before the first frame update

    public void start()
    {
        startTimeScale= Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime; 

        StartSlowMotion();

        c = WaitAndStopSlowMotion(slowMotionDuration);
        StartCoroutine(c); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void StartSlowMotion(){
        Time.timeScale = slowMotionTimeScale; 
        Time.fixedDeltaTime= startFixedDeltaTime *slowMotionTimeScale; 
        //StartCoroutine(WaitAndStopSlowMotion());
    }

    private void StopSlowMotion(){
        Debug.Log("bong");
        Time.timeScale= startTimeScale; 
        Time.fixedDeltaTime = startFixedDeltaTime; 
    }

    IEnumerator WaitAndStopSlowMotion(float slowMotionDuration ){
        Debug.Log("Bing");
        yield return new WaitForSeconds(slowMotionDuration);
        StopSlowMotion(); 
    }
}

