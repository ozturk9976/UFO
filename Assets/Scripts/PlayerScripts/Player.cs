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
    IEnumerator BekleieNumerator;
    public AudioSource shieldaudio;

    Vector2 hareket;

    Rigidbody2D rb;

    void Start()
    {
        currentHealth = PlayerHealth;
        ScoreCount.scoreValue = 0;
        rb = GetComponent<Rigidbody2D>();
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        shieldaudio = GetComponent<AudioSource>();
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

    // void isThereAShield()
    // {
    //     currentHealth += 20;
    //     Destroy(shield);
    // }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("EnemyBullet"))
        {
            // isThereAShield();
            currentHealth -= 20;
            Die();
        }
        if (col.gameObject.tag.Equals("Enemy"))
        {
            shake.CamShake();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }

    void Die()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
            StartCoroutine(Text());
        }
    }

    IEnumerator Text() //  <-  its a standalone method
    {
        Debug.Log("Hell12o");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOverScene");
    }
}
