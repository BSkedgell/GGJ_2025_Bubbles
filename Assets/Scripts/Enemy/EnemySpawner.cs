using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11), 5, Random.Range(-10,11));
        Instantiate(enemy, randomSpawnPosition, Quaternion.identity);
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
