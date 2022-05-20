using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiresAtYou : MonoBehaviour
{
    public GameObject bullet;
    float fireRate;
    float nextFire;
    public Transform olusumNoktasi;
    public Transform olusumNoktasi2;
    public Transform olusumNoktasi3;
    public Transform olusumNoktasi4;

    // GameObject target;



    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
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
            Instantiate(bullet, olusumNoktasi2.transform.position, Quaternion.identity);
            Instantiate(bullet, olusumNoktasi3.transform.position, Quaternion.identity);
            Instantiate(bullet, olusumNoktasi4.transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
