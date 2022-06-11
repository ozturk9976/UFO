using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSSLEVEL : MonoBehaviour
{
    public GameObject BossLevel;
    public GameObject Boss;

    public Transform playerPosition;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (ScoreCount.scoreValue == 350)
        {
            Instantiate(BossLevel, transform.position, Quaternion.identity);
            Instantiate(Boss, transform.position, Quaternion.identity);
        }
    }
}
