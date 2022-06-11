using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    private float dirX;
    private float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = false;
    private Vector3 localScale;
    public bool bossisSpawned;

    // Start is called before the first frame update
    void Start()
    {
        bossisSpawned = true;
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX = -1f;
        moveSpeed = 2f;
    }

    private void OnCollisionEnter2D(Collider2D col)
    {
        if (col.GetComponent<Wall>())
        {
            dirX *= -1;
        }
    }

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
}
