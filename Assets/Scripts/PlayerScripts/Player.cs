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
        bekle = StartCoroutine(beklecoroutine());
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
        // if (col.gameObject.tag.Equals("Shield"))
        // {
        //     Instantiate(shield, transform.position, Quaternion.identity);
        //     beklecoroutine();
        //     Destroy(shield);
        // }
        if (col.gameObject.tag.Equals("Shield"))
        {
            Instantiate(shield, PlayerSprite);
            Destroy(col.gameObject);
            Destroy(shield, 15f);
            shieldaudio.Play();
            // Instantiate(shield, transform.position, Quaternion.identity);
        }
        if (col.gameObject.tag.Equals("EnemyBullet"))
        {
            // isThereAShield();
            currentHealth -= 20;
            Debug.Log("nabers");
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
        }
    }

    IEnumerator beklecoroutine()
    {
        yield return new WaitForSeconds(15f);
    }
}
