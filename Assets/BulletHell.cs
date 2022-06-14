// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BulletHell : MonoBehaviour
// {
//     private float angle = 0f;

//     // Start is called before the first frame update
//     void Start()
//     {
//         InvokeRepeating("fire", 0f, 0.1f);
//     }

//     // Update is called once per frame
//     void Update() { }

//     private void fire()
//     {
//         float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
//         float bulDiry = transform.position.y + Mathf.Sin((angle * Mathf.PI) / 180f);

//         Vector3 bulMoveVector = new Vector3(bulDirX, bulDiry, 0f);
//         Vector2 bulDir = (bulMoveVector - transform.position).normalized;
//         GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
//         bul.transform.position = transform.position;
//         bul.transform.rotation = transform.rotation;
//         bul.SetActive(true);
//         bul.GetComponent<Bullet>().SetMoveDirection(bulDir);
//     }
// }
