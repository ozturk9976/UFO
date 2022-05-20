using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//gameobjekte eklenen rb ye erişim sağlanır
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Enemy"|| collision.gameObject.tag =="Floor")
        {
            Destroy(gameObject); //eğer Destroy(collision.gameObject) yazılırsa diğer obje yokedilir
        }
    }
}
