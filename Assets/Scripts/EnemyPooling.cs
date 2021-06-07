using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{

    public int enemyPoolSize = 10;

    public GameObject enemyPrefab;

    public float spawnRate = 2f;

    public float spawnMin = -1f;

    public float spawnMax = 3.5f;

    //public float spawnYPosition = 5f;



    private GameObject[] enemy;

    private Vector3 enemyPoolPosition = new Vector3(-5, 3, -6);

    private float timeSinceLastSpawned;

    private int currentSpawn;



    // Start is called before the first frame update
    void Start()
    {

        enemy = new GameObject[enemyPoolSize];

        for(int i = 0; i < enemyPoolSize; i++)
        {

            enemy[i] = (GameObject)Instantiate(enemyPrefab, enemyPoolPosition, Quaternion.Euler(0, 90, 0));

        }

    }

    // Update is called once per frame
    void Update()
    {

        timeSinceLastSpawned += Time.deltaTime;

        if (timeSinceLastSpawned > spawnRate)
        {

            timeSinceLastSpawned = 0;

            float spawnXPosition = Random.Range(-9, 11);

            float spawnYPosition = Random.Range(1, 5);

            float spawnZPosition = Random.Range(-4, 1);

            enemy[currentSpawn].transform.position = new Vector3(spawnXPosition, spawnYPosition, spawnZPosition);

            currentSpawn++;

            if(currentSpawn >= enemyPoolSize)
            {
                currentSpawn = 0;
            }

        }

    }
}
