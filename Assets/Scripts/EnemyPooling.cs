using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{

    public int enemyPoolSize = 10;  //enemyPoolSize

    public GameObject enemyPrefab; //Enemy prefab

    public float spawnRate = 2f; //Rate at which enemy spawns

    public float spawnMin = -1f; // Minimum value

    public float spawnMax = 3.5f; // max value

    //public float spawnYPosition = 5f;



    private GameObject[] enemy; //collection of enemies

    private Vector3 enemyPoolPosition = new Vector3(-5, 3, -6); //holding position

    private float timeSinceLastSpawned; //time count

    private int currentSpawn;



    // Start is called before the first frame update
    void Start()
    {
        //initialize pool collection
        enemy = new GameObject[enemyPoolSize];

        for(int i = 0; i < enemyPoolSize; i++) //loop through collection
        {

            enemy[i] = (GameObject)Instantiate(enemyPrefab, enemyPoolPosition, Quaternion.Euler(0, 90, 0));
            //create individual pool
        }

    }

    // Update is called once per frame
    void Update()
    {

        timeSinceLastSpawned += Time.deltaTime;

        if (timeSinceLastSpawned > spawnRate)
        {

            timeSinceLastSpawned = 0;

            float spawnXPosition = Random.Range(-9, 11); //random x position

            float spawnYPosition = Random.Range(1, 5); //random y position

            float spawnZPosition = Random.Range(-4, 1); //random z position

            enemy[currentSpawn].transform.position = new Vector3(spawnXPosition, spawnYPosition, spawnZPosition);

            currentSpawn++; //increase collection

            if(currentSpawn >= enemyPoolSize)
            {
                currentSpawn = 0;
            }

        }

    }
}
