using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBall : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Mermi1;

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
        if (Input.GetKeyDown(KeyCode.J)) //GETKEY İLE YAPILINCA BİRSÜRÜ MERMİ SPAWNLAN
        {
            dropFireBallRight();
            source.Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
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

    void dropFireBallRight()
    {
        
        GameObject Mermi2 = Instantiate(
            Mermi1,
            olusumNoktasi2.transform.position,
            transform.rotation
        );
        Mermi2.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce * Time.deltaTime);
    }

    void dropFireBallLeft()
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

    // void dropFireBallDown()
    // {
    //     GameObject Mermi4 = Instantiate(
    //         Mermi1,
    //         olusumNoktasi4.transform.position,
    //         transform.rotation
    //     );
    //     Mermi4.GetComponent<Rigidbody2D>().AddForce(-transform.up * LaunchForce * Time.deltaTime);
    // },

}
