using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    private GameObject ammo;

    [SerializeField]
    private Transform fireTransformRight;

    [SerializeField]
    private Transform fireTransformLeft;

    [SerializeField]
    private float AtısHızı = 0.5f;
    private float suankiAtıs = 0f;

    private float LaunchForce = 25f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (suankiAtıs > 0f)
        {
            suankiAtıs -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.J))
        {
            if (suankiAtıs <= 0)
            {
                FireRight();
            }
            ;
        }
        if (Input.GetKey(KeyCode.G))
        {
            if (suankiAtıs <= 0)
            {
                FireLeft();
            }
            ;
        }
    }

    private void FireRight()
    {
        suankiAtıs = AtısHızı;
        Instantiate(ammo, fireTransformRight.position, Quaternion.identity);
        ammo.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce * Time.deltaTime);
    }

    private void FireLeft()
    {
        suankiAtıs = AtısHızı;
        Instantiate(ammo, fireTransformLeft.position, Quaternion.identity);
        ammo.GetComponent<Rigidbody2D>().AddForce(-transform.right * LaunchForce * Time.deltaTime);
    }
}
