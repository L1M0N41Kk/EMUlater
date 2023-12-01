using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyInstance;
    public Transform[] spawnPoints;
    public float spawnRate = 2f;
    public float spawnRateIncrease = 0.1f;
    public float minSpawnRate = 0.5f;


    private float nextSpawnTime = 1f;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnRate;
            ReduceSpawnRate();
        }
    }

    private void SpawnEnemy()
    {
        Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        enemyInstance = Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);       
    }

    void ReduceSpawnRate()
    {
        if (spawnRate > minSpawnRate)
        {
            spawnRate -= spawnRateIncrease;
            if (spawnRate < minSpawnRate)
            {
                spawnRate = minSpawnRate;
            }
        }
    }
}