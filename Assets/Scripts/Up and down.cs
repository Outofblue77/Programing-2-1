using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Upanddown : MonoBehaviour
{

    float flytime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        

        if (flytime <= 40)
        {
            flytime += 1;
            pos.y += 0.001f;
        }

        if (flytime == 80)
        {
            flytime = 0;
        }

        if (flytime > 40)
        {
            flytime += 1;
            pos.y -= 0.001f;
        }


        transform.position = pos;

    }
}
