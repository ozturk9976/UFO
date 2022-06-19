using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    public int bossHealth;
    private int currentBossHealth = 100;
    private float dirX;
    private float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = false;
    private Vector3 localScale;

    // Start is called before the first frame update
    void Start()
    {
        bossHealth = currentBossHealth;
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX = -1f;
        moveSpeed = 3f;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Wall"))
        {
            dirX *= -1;
        }
    }

    private void OnCollisionEnter2D(Collider2D collider) { }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    void CheckWhereToFace()
    {
        if (dirX > 0)
        {
            facingRight = true;
        }
        else if (dirX < 0)
        {
            facingRight = false;
        }
        if (((facingRight && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0))))
        {
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }

    // Update is called once per frame
    void Update() { }

    void die()
    {
        if (currentBossHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
