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
    private Vector3 mermiAngle;

    private float ang = 45f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && Time.time > nextFire)
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
        }
    }

    // public void dropFireBallRight()
    // {
    //     Vector3 angle1 = new Vector3(0f, 15f, 44f);
    //     Vector3 mermiAngle = transform.right - angle1;
    //     Vector3 angle2 = new Vector3(0f, 0f, 0f);
    //     Vector3 mermiAngle2 = transform.right - angle2;
    //     Vector3 angle3 = new Vector3(0f, -15f, -44f);
    //     Vector3 mermiAngle3 = transform.right - angle3;

    //     for (int i = 0; i < ammoCount; i++)
    //     {
    //         GameObject Mermi2 = Instantiate(
    //             Mermi1,
    //             olusumNoktasi.transform.position,
    //             transform.rotation
    //         );
    //         Mermi2.GetComponent<Rigidbody2D>().AddForce(mermiAngle * LaunchForce * Time.deltaTime);
    //         GameObject Mermi3 = Instantiate(
    //             Mermi1,
    //             olusumNoktasi.transform.position,
    //             transform.rotation
    //         );
    //         Mermi2.GetComponent<Rigidbody2D>().AddForce(mermiAngle2 * LaunchForce * Time.deltaTime);
    //         GameObject Mermi4 = Instantiate(
    //             Mermi1,
    //             olusumNoktasi.transform.position,
    //             transform.rotation
    //         );
    //         Mermi2.GetComponent<Rigidbody2D>().AddForce(mermiAngle3 * LaunchForce * Time.deltaTime);
    //     }
    // }
    public void dropFireBallRight()
    {
        for (int i = 0; i < ammoCount; i++)
        {
            GameObject Mermi3 = Instantiate(
                Mermi1,
                olusumNoktasi.transform.position,
                transform.rotation
            );
            Mermi3
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
