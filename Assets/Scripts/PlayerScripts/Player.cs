using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float hareketGucu;
    public Animator explosion;
    private Shake shake;

    Vector2 hareket;
    public Renderer rend;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // IEnumerator waitToPass()
    // {
    //     gameObject.SetActive(false);
    //     yield return new WaitForSeconds(3f);
    //     SceneManager.LoadScene("GameOverScene");

    //     Destroy(gameObject);
    // }

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
        if (col.gameObject.tag.Equals("Enemy"))
        {
            // StartCoroutine(waitToPass());
            shake.CamShake();
            Instantiate(explosion, transform.position, Quaternion.identity);
            // rend.enabled = false;
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
