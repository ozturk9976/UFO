using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform followTransform;
    public Transform rotateTransform;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(
            followTransform.position.x,
            followTransform.position.y,
            followTransform.position.z - 10
        );
        // transform.Rotate(0, 0, 0.1f); //transform.position.z);
    }
}
