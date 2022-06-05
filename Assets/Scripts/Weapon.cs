// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// [CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
// public class Weapon : ScriptableObject
// {
//     private float nextFire = 0.0F;
//     public AudioSource source;
//     public Sprite currentWeaponSpr;
//     public float fireRate = 1;
//     public int damage = 20;

//     public GameObject bulletPrefab;

//     public class Shooting : MonoBehaviour
//     {
//         public Transform olusumNoktasi2;
//         public Transform olusumNoktasi3;
//         public GameObject bulletPrefab;
//         public float LaunchForce = 25f;

//         public void dropFireBallRight()
//         {
//             GameObject Mermi2 = Instantiate(
//                 bulletPrefab,
//                 olusumNoktasi2.transform.position,
//                 transform.rotation
//             );
//             Mermi2
//                 .GetComponent<Rigidbody2D>()
//                 .AddForce(transform.right * LaunchForce * Time.deltaTime);
//         }

//         public void dropFireBallLeft()
//         {
//             GameObject Mermi3 = Instantiate(
//                 bulletPrefab,
//                 olusumNoktasi3.transform.position,
//                 transform.rotation
//             );
//             Mermi3
//                 .GetComponent<Rigidbody2D>()
//                 .AddForce(-transform.right * LaunchForce * Time.deltaTime);
//         }
//     }
// }
