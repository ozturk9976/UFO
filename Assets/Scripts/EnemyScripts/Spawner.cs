using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRadius = 6.1f,
        time = 1.5f;
    public GameObject[] enemies;

    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    void Update()
    {
        if (ScoreCount.scoreValue == 15)
        {
            time = 1.1f;
        }
        if (ScoreCount.scoreValue == 35)
        {
            time = 1f;
        }
        if (ScoreCount.scoreValue == 55)
        {
            time = 0.9f;
        }
        if (ScoreCount.scoreValue == 75)
        {
            time = 0.8f;
        }
        if (ScoreCount.scoreValue == 115)
        {
            time = 0.7f;
        }
        if (ScoreCount.scoreValue == 135)
        {
            time = 0.62f;
        }
        if (ScoreCount.scoreValue == 155)
        {
            time = 0.59f;
        }
        if (ScoreCount.scoreValue == 175)
        {
            time = 0.5f;
        }
        if (ScoreCount.scoreValue == 200)
        {
            time = 0.4f;
        }
        if (ScoreCount.scoreValue == 225)
        {
            time = 0.3f;
        }
        if (ScoreCount.scoreValue == 250)
        {
            time = 0.27f;
        }
        if (ScoreCount.scoreValue == 275)
        {
            time = 0.23f;
        }
        if (ScoreCount.scoreValue == 300)
        {
            time = 0.21f;
        }
        if (ScoreCount.scoreValue == 350)
        {
            time = 0.18f;
        }
    }

    IEnumerator SpawnAnEnemy()
    {
        Vector2 spawnPos = GameObject.FindGameObjectWithTag("Player").transform.position;

        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnAnEnemy());
    }
}
