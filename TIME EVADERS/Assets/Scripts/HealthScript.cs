using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{

    public Sprite tenHealth;
    public Sprite nineHealth;
    public Sprite eightHealth;
    public Sprite sevenHealth;
    public Sprite sixHealth;
    public Sprite fiveHealth;
    public Sprite fourHealth;
    public Sprite threeHealth;
    public Sprite twoHealth;
    public Sprite oneHealth;
    public Sprite noHealth;
    public AudioSource heartsLoss;
    
 

    public int lives = 10;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = tenHealth;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = tenHealth;
            
        }

        else if (lives == 9)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = nineHealth;
            
            
        }
        else if (lives == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = eightHealth;
            
        }
        else if (lives == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sevenHealth;
            
        }
        else if (lives == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sixHealth;
            
        }
        else if (lives == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fiveHealth;
            
        }
        else if (lives == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fourHealth;
         
        }
        else if (lives == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = threeHealth;
            
        }
        else if (lives == 2)
        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = twoHealth;
            
        }
        else if (lives == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = oneHealth;
            
        }
        else // lives = 0
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = noHealth;
            SceneManager.LoadScene(2);
        }

    }
    public void loseHearts()
    {
        heartsLoss.Play();
    }

}
