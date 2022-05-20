using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0); // 0 bir parmak dokunuşunu ifade eder

            if (parmak.phase == TouchPhase.Began)
            {
                Debug.Log("dokundu");
                Debug.Log(parmak.position);
            }
            if (parmak.phase == TouchPhase.Stationary)
            {
                Debug.Log("dokunuyor");
            }
            if (parmak.phase == TouchPhase.Moved)
            {
                Debug.Log("sürükleniyor");
            }
            if (parmak.phase == TouchPhase.Ended)
            {
                Debug.Log("bitti");
            }
            Debug.Log(parmak.deltaPosition); //x ve y koordinatlarındaki pixel değişimleri
        }
    }
}
