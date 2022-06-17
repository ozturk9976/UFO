using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int EnemyHealthMax = 100;
    public int enemycurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        enemycurrentHealth = EnemyHealthMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemycurrentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            enemycurrentHealth -= 50;
        }
    }
}
