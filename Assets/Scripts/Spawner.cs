using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 5,
        time = 1.5f;
    public GameObject[] enemies;

    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    void Update()
    {
        //if (UITimer.TimerText.text.minutes == "35") { }
        if (ScoreCount.scoreValue == 55)
        {
            time = 1.1f;
        }
        if (ScoreCount.scoreValue == 15)
        {
            time = 0.9f;
        }
        if (ScoreCount.scoreValue == 35)
        {
            time = 0.7f;
        }
        if (ScoreCount.scoreValue == 85)
        {
            time = 0.5f;
        }
        if (ScoreCount.scoreValue == 85)
        {
            time = 0.3f;
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
