using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class spawning : MonoBehaviour
{
    public GameObject watch; // Prefab to spawn
    public GameObject bomb;
    public GameObject goldball;
    public GameObject boss;
    public Transform centerObject; // Object to move towards
    public float spawnInterval; // Time between spawns
    public float moveSpeed = 1.5f; // Speed at which spawned objects move towards center object
    public float gbSpeed = 5f;
    public float bossSpeed = 2.5f;
    public float wave = 1f; //start with wave 1
    private float spawnTimer = 0f;
    public Text waveText;
    private int numSpawned = 0;
    public int maxSpawned = 20;
    private float difficulty = 2.5f;
    private Vector3 direction;
    public TextMeshProUGUI yearstraveled;
    public GameObject yearsupdater;
    public int numSpawnedBosses = 0;
    public GameObject bosswarning;
    public AudioSource waves;
    public AudioSource bossAlarm;


    

    public void Start()
    {
        bosswarning.SetActive(false);
    }


    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            spawnInterval = ((100f - ((wave - 1f) * difficulty)) / 100); // spawn interval decreases 2.5% with each wave //spawn 40% per person after first
            spawnTimer = spawnInterval;

            // Generate random spawn position on border
            Vector2 spawnPos = GetRandomSpawnPosition();
            Vector2 spawnPos2 = GetRandomSpawnPosition();

            // Spawn object at spawn position

            if (wave % 5 == 0)
            {
                numSpawnedBosses = 0;
                bosswarning.SetActive(true);
                if (numSpawnedBosses < 10)
                {
                    SpawnBosses(spawnPos);
                    numSpawnedBosses++;
                    bossAlarm.Play();
                }
            }
            else
            {
                bosswarning.SetActive(false);
                // Spawn normal objects
                SpawnObject(spawnPos);
            }
            numSpawned++;
        }
        if (numSpawned == maxSpawned)
        {
            // next wave
            wave++;
            waves.Play();
            numSpawned = 0;
            waveText.text = ("Wave:\n" + wave.ToString());
            yearsupdater.GetComponent<yearsint>().yearstraveledint += 50;

        }

    }


    void SpawnObject(Vector2 spawnPos)
    {
        // Convert screen position to world position
        Vector2 worldPos = Camera.main.ViewportToWorldPoint(spawnPos);

        // Spawn object at world position
        int num = Random.Range(0, 100);
        if (num < 21) //create time // 20% CHANCE
        {
            GameObject obj1 = Instantiate(watch, worldPos, Quaternion.identity);
            // Set object's movement towards center object
            movement moveScript = obj1.GetComponent<movement>();
            if (moveScript != null)
            {
                moveScript.SetTarget(centerObject);
                moveScript.SetSpeed(moveSpeed);
            }

            //ObjectActions oaf = obj1.GetComponent<ObjectActions>();
            //oaf.spawner = this;

            //ObjectActions oaf = obj1.GetComponent<ObjectActions>();
            //oaf.spawner = this;*/
        }
        else if (num < 26) //5% CHANCE
        {
            GameObject obj4 = Instantiate(goldball, worldPos, Quaternion.identity);
            movement moveScript = obj4.GetComponent<movement>();
            if(moveScript != null)
            {
                moveScript.SetTarget(centerObject);
                moveScript.SetSpeed(gbSpeed);
            }

        }
        else //create enemy //75% CHANCE
        {

            GameObject obj3 = Instantiate(bomb, worldPos, Quaternion.identity);
            // Set object's movement towards center object
            movement moveScript = obj3.GetComponent<movement>();
            if (moveScript != null)
            {
                moveScript.SetTarget(centerObject);
                moveScript.SetSpeed(moveSpeed);
            }

        }
    }

    void SpawnBosses(Vector2 spawnPos)
    {
        Vector2 worldPos = Camera.main.ViewportToWorldPoint(spawnPos);
        GameObject obj5 = Instantiate (boss, worldPos, Quaternion.identity);
        movement moveScript = obj5.GetComponent<movement>();
        if (moveScript != null)
        {
            moveScript.SetTarget(centerObject);
            moveScript.SetSpeed(bossSpeed);
        }
    }

    Vector2 GetRandomSpawnPosition()
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);

        if (x > y)
        {
            if (x > 1 - y)
            {
                // Spawn on right border
                return new Vector2(0.8f, Random.Range(0.2f, 0.8f));
            }   
            else
            {   
                // Spawn on top border
                return new Vector2(Random.Range(0.2f, 0.8f), 0.8f);
            }
        }
        else
        {
            if (x > 1 - y)
            {
                // Spawn on bottom border
                return new Vector2(Random.Range(0.2f, 0.8f), 0.2f);
            }
            else
            {
                // Spawn on left border
                return new Vector2(0.2f, Random.Range(0.2f, 0.8f));
            }
        }
    }
}
