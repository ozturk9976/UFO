using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private Image HealthImage;

    // Start is called before the first frame update
    void Start()
    {
        HealthImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthImage.fillAmount =
            GetComponent<Player>().PlayerHealth / GetComponent<Player>().currentHealth;
    }
}
