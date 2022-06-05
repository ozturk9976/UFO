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

    private float nextTimeOfFire = 0;

    public Transform olusumNoktasi;
    public Transform olusumNoktasi2;
    public Transform olusumNoktasi3;
    public Transform olusumNoktasi4;

    private AudioSource source;

    public float LaunchForce = 25f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J) && Time.time > nextFire) //GETKEY İLE YAPILINCA BİRSÜRÜ MERMİ SPAWNLAN
        {
            nextFire = Time.time + fireRate;
            dropFireBallRight();
            source.Play();
        }
        if (Input.GetKey(KeyCode.G) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            dropFireBallLeft();
            source.Play();
        }
    }

    // void dropFireBallUp()
    // {
    //     GameObject Mermi = Instantiate(
    //         Mermi1,
    //         olusumNoktasi.transform.position,
    //         transform.rotation
    //     );
    //     Mermi.GetComponent<Rigidbody2D>().AddForce(transform.up * LaunchForce * Time.deltaTime);
    // }

    public void dropFireBallRight()
    {
        GameObject Mermi2 = Instantiate(
            Mermi1,
            olusumNoktasi.transform.position,
            transform.rotation
        );
        Mermi2.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce * Time.deltaTime);
        // for (int i = 0; i < 3; i++)
        // {
        //     GameObject Mermi2 = Instantiate(
        //         Mermi1,
        //         olusumNoktasi.transform.position,
        //         transform.rotation
        //     );
        //     Mermi2
        //         .GetComponent<Rigidbody2D>()
        //         .AddForce(transform.right * LaunchForce * Time.deltaTime);
        // }
        ;
        // Mermi2
        //     .GetComponent<Rigidbody2D>()
        //     .AddForce(transform.right * LaunchForce + new Vector3(0f, -90f, 0f) * Time.deltaTime);
        // GameObject Mermi3 = Instantiate(
        //     Mermi1,
        //     olusumNoktasi2.transform.position,
        //     transform.rotation
        // );
        // Mermi2
        //     .GetComponent<Rigidbody2D>()
        //     .AddForce(transform.right * LaunchForce + new Vector3(0f, 0f, 0f) * Time.deltaTime);
        // GameObject Mermi4 = Instantiate(
        //     Mermi1,
        //     olusumNoktasi3.transform.position,
        //     transform.rotation
        // );
        // Mermi2
        //     .GetComponent<Rigidbody2D>()
        //     .AddForce(transform.right * LaunchForce + new Vector3(0f, 90f, 0f) * Time.deltaTime);
    }

    public void dropFireBallLeft()
    {
        GameObject Mermi3 = Instantiate(
            Mermi1,
            olusumNoktasi3.transform.position,
            transform.rotation
        );
        Mermi3
            .GetComponent<Rigidbody2D>()
            .AddForce(-transform.right * LaunchForce * Time.deltaTime);
    }
}
// void dropFireBallDown()
// {
//     GameObject Mermi4 = Instantiate(
//         Mermi1,
//         olusumNoktasi4.transform.position,
//         transform.rotation
//     );
//     Mermi4.GetComponent<Rigidbody2D>().AddForce(-transform.up * LaunchForce * Time.deltaTime);
// }

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
