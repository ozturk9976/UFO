using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelExplosion : MonoBehaviour
{
    public float destroyTime = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update() { }
}
