using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.75f);
    }

    // Update is called once per frame
    void Update() { }

    void OnCollisionEnter2D(Collider2D col)
    {
        if (
            col.gameObject.tag.Equals("Enemy")
            || col.gameObject.tag.Equals("Border")
            || col.gameObject.tag.Equals("BossTag")
        )
        {
            Destroy(gameObject);
        }
    }
}
