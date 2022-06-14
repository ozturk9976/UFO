using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    public Animator explosion;
    public GameObject particleExplosion;
    private Shake shake;
    public GameObject floatingScore;

    private GameObject Script;

    // Start is called before the first frame update
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        rb = GetComponent<Rigidbody2D>();

        // Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update() { }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            shake.CamShake();
            Destroy(gameObject);
            Destroy(col.gameObject);
            Instantiate(floatingScore, transform.position, Quaternion.identity);
            Instantiate(particleExplosion, transform.position, Quaternion.identity);
            Instantiate(explosion, transform.position, Quaternion.identity);
            ScoreCount.scoreValue += 1;
        }
    }
}
