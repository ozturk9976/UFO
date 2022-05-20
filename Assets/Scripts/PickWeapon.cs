using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickWeapon : MonoBehaviour
{
    public Weapon weapon;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player") { }
    }
}
