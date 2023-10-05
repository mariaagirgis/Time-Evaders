using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movement : MonoBehaviour
{
    public float speed = 0f; // Speed at which object moves towards center
    private Transform target; // Target object to move towards
    public GameObject healthBar;
    private Vector3 direction;
    public GameObject yearsupdater;
    public TextMeshProUGUI yearstraveled;

    void Start()
    {
    }
 
    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction.normalized;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void Update()
    {
        if (target != null)
        {

            // Calculate direction towards target object
            Vector3 dir = target.position - transform.position;

            // Move object towards target object
            transform.position += dir.normalized * speed * Time.deltaTime;
            if ((Mathf.Abs(target.position.x - transform.position.x) < 0.5) && (Mathf.Abs(target.position.y - transform.position.y) < 0.5))
            {
                Object.Destroy(gameObject);
                if (this.gameObject.tag == "enemy")
                    {
                    healthBar.GetComponent<HealthScript>().lives--;
                    healthBar.GetComponent<HealthScript>().loseHearts();

                }
                else if (this.gameObject.tag == "watch")
                {
                    yearsupdater.GetComponent<yearsint>().yearstraveledint += 10;
                }
                else if (this.gameObject.tag == "boss")
                {
                    healthBar.GetComponent<HealthScript>().lives--;
                    healthBar.GetComponent<HealthScript>().loseHearts();
                    Debug.Log("Lost life");
                }
            }

        }
    }

    private void OnMouseDown()
    {
        Object.Destroy(gameObject);  
        if (this.gameObject.tag == "watch")
        {
            healthBar.GetComponent<HealthScript>().lives--;
            healthBar.GetComponent<HealthScript>().loseHearts();
            Debug.Log("Lost life");
        }

        else if (this.gameObject.tag == "goldball")
        {
            yearsupdater.GetComponent<yearsint>().yearstraveledint += 200;
        }



    }
}