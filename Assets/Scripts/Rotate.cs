using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 1f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    public void Rotation()
    {
        transform.Rotate(new Vector3(0f, 0f, 3f) * Time.deltaTime * rotateSpeed);
    }
}
