using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<Transform> spawnPoints;
    public float initialDelay = 0f; // 生成第一个敌人的延迟时间
    public float spawnInterval = 30f; // 生成敌人的时间间隔

    void Start()
    {
        Invoke("SpawnEnemy", initialDelay);
        InvokeRepeating("SpawnEnemy", initialDelay + spawnInterval, spawnInterval);
    }

    // void SpawnEnemy()
    // {
    //     int randomIndex = Random.Range(0, spawnPoints.Count);
    //     Instantiate(enemyPrefab, spawnPoints[randomIndex].position, spawnPoints[randomIndex].rotation);
    // }
    void SpawnEnemy()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
