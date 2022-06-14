using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUfo : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnRadius = 6.1f,
        time = 7f;
    public GameObject[] enemies1;

    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    void Update()
    {
        //if (UITimer.TimerText.text.minutes == "35") { }
        if (ScoreCount.scoreValue == 15)
        {
            time = 6f;
        }
        if (ScoreCount.scoreValue == 55)
        {
            time = 5.7f;
        }
        if (ScoreCount.scoreValue == 85)
        {
            time = 5.25f;
        }

        if (ScoreCount.scoreValue == 125)
        {
            time = 4.6f;
        }
        if (ScoreCount.scoreValue == 85)
        {
            time = 4.3f;
        }
    }

    IEnumerator SpawnAnEnemy()
    {
        Vector2 spawnPos = GameObject.FindGameObjectWithTag("Player").transform.position;

        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemies1[Random.Range(0, enemies1.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnAnEnemy());
    }
}
