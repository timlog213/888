using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy enemyPrefab;

    public Transform topBorder;
    public Transform bottomBorder;

    public float spawnInterval = 1f;
    public float spawnTimer = 0f;

    public float spawnIntervalMax = 3.5f;
    public float spawnIntervalMin = 1f;

    public int spawnCounter = 10;

    public void Spawn()
    {
        Vector2 randomPosition = new Vector2(transform.position.x, Random.Range(bottomBorder.position.x, topBorder.position.y));
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);
        spawnCounter--;
    }

    private void Update()
    {
        if (spawnTimer <= 0)
        {
            Spawn();
            spawnTimer = spawnInterval;
        }
    }
}
