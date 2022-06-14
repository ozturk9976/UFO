using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBall : MonoBehaviour
{
    Rigidbody2D rb;
    public float fireRate = 0.7F;
    private float nextFire = 0.0F;
    public GameObject Mermi1;
    public int ammoCount = 1;

    public Transform olusumNoktasi;
    public Transform olusumNoktasi2;

    private AudioSource source;

    public float LaunchForce = 25f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && Time.time > nextFire) //GETKEY İLE YAPILINCA BİRSÜRÜ MERMİ SPAWNLAN
        {
            nextFire = Time.time + fireRate;
            dropFireBallRight();
            source.Play();
        }
        if (Input.GetKey(KeyCode.Q) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            dropFireBallLeft();
            source.Play();

            if (ScoreCount.scoreValue == 15)
            {
                ammoCount += 15;
            }
        }
    }

    public void dropFireBallRight()
    {
        for (int i = 0; i < ammoCount; i++)
        {
            GameObject Mermi2 = Instantiate(
                Mermi1,
                olusumNoktasi.transform.position,
                transform.rotation
            );
            Mermi2
                .GetComponent<Rigidbody2D>()
                .AddForce(transform.right * LaunchForce * Time.deltaTime);
        }
    }

    public void dropFireBallLeft()
    {
        for (int i = 0; i < ammoCount; i++)
        {
            GameObject Mermi3 = Instantiate(
                Mermi1,
                olusumNoktasi2.transform.position,
                transform.rotation
            );
            Mermi3
                .GetComponent<Rigidbody2D>()
                .AddForce(-transform.right * LaunchForce * Time.deltaTime);
        }
    }
}



//     //shotgun  for (int i = 0; i < 2; i++)
//             {
//                 var spawnedBullet = Instantiate(
//                     Mermi1,
//                     olusumNoktasi2.transform.position,
//                     transform.rotation
//                 );
//                 switch (i)
//                 {
//                     case 0:
//                         spawnedBullet
//                             .GetComponent<Rigidbody2D>()
//                             .AddForce(olusumNoktasi2.up * LaunchForce + new Vector3(0f, -90f, 0f));
//                         break;
//                     case 1:
//                         spawnedBullet
//                             .GetComponent<Rigidbody2D>()
//                             .AddForce(olusumNoktasi2.up * LaunchForce + new Vector3(0f, 0f, 0f));
//                         break;
//                     case 2:
//                         spawnedBullet
//                             .GetComponent<Rigidbody2D>()
//                             .AddForce(olusumNoktasi2.up * LaunchForce + new Vector3(0f, 90f, 0f));
//                         break;
//                 }
//             }
// }
