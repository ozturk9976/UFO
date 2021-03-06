using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float hareketGucu;
    public Animator explosion;
    private Shake shake;

    [SerializeField]
    public int PlayerHealth = 100;
    public int currentHealth;
    public GameObject shield;
    public Transform PlayerSprite;
    Coroutine bekle;

    private bool isDead;

    Vector2 hareket;

    Rigidbody2D rb;

    void Start()
    {
        
        currentHealth = PlayerHealth;
        ScoreCount.scoreValue = 0;
        rb = GetComponent<Rigidbody2D>();
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    void Update()
    {
        hareket.x = Input.GetAxisRaw("Horizontal");
        hareket.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + hareket * hareketGucu * Time.fixedDeltaTime);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("EnemyBullet"))
        {
            Destroy(col.gameObject);
            currentHealth -= 20;
            Die();
            
        }
        if (col.gameObject.tag.Equals("Enemy") || (col.gameObject.tag.Equals("Border")))
        {
            shake.CamShake();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }
    void sceneChange()
    {
        if (isDead == true)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    void Die()
    {
        if (currentHealth == 0)
        {
            isDead = true;                  
            Destroy(gameObject);
            StartCoroutine(ExampleCoroutine());
            SceneManager.LoadScene("GameOverScene");
        }
    }
    IEnumerator ExampleCoroutine()
    {          
        yield return new WaitForSeconds(3);       
    }
}

