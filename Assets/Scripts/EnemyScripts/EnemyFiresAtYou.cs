using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiresAtYou : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate;
    float nextFire;
    public Transform olusumNoktasi;
    public Transform olusumNoktasi2;
    public float BulletSpeed = 15;

    public Player target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindObjectOfType<Player>();
        fireRate = 1f;
        nextFire = Time.time;
        nextFire = Time.time + fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire) // eğer şu anki zaman nextfire değerinden fazla ise true.
        {
            Instantiate(bullet, olusumNoktasi.transform.position, Quaternion.identity);

            nextFire = Time.time + fireRate;
            bullet
                .GetComponent<Rigidbody2D>()
                .AddForce(
                    (target.transform.position - transform.position) * BulletSpeed * Time.deltaTime
                );
            Instantiate(bullet, olusumNoktasi2.transform.position, Quaternion.identity);

            nextFire = Time.time + fireRate;
            bullet
                .GetComponent<Rigidbody2D>()
                .AddForce(
                    (target.transform.position - transform.position) * BulletSpeed * Time.deltaTime
                );
        }
    }
}
