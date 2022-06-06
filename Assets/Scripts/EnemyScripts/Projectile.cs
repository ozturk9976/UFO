using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector2 target;

    public GameObject projectileDestroyParticle;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);

        Destroy(gameObject, 7f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
            Instantiate(projectileDestroyParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
        if (col.CompareTag("Player"))
        {
            Instantiate(projectileDestroyParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            player.position, //player.position dersen takip eder // target dersen normal
            speed * Time.deltaTime
        );
    }
}
