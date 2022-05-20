using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Vector2 moveDirection;
    // Rigidbody2D rb;

    // float speed = 10;

    // GameObject player;

    // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    //     player = GameObject.FindGameObjectWithTag<>("Player").transform;
    //     // target = GameObject.FindObjectOfType<Space>();
    //     moveDirection = (player.transform.position - transform.position).normalized * speed;
    //     rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    //     //Destroy(gameObject, 3f);}

    //     // Update is called once per frame
    //     void Update()
    //     {
    //         void OnCollisionEnter2D(Collider2D col)
    //         {
    //             if (col.gameObject.tag == "Player")
    //             {
    //                 Debug.Log("hit");
    //                 Destroy(gameObject);
    //             }
    //         }
    //     }
    // }
    float moveSpeed = 15f;

    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Enemy"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }
}
