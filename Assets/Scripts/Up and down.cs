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

        //Creaitng timer

        if (flytime <= 40) //If timer less than 40 move bird one way
        {
            flytime += 1;
            pos.y += 0.001f;
        }

        if (flytime == 80) //If timer equals 80 restart cycle
        {
            flytime = 0; //Reset cycle
        }

        if (flytime > 40) //If timer passes 40 ticks more bird opposite way
        {
            flytime += 1;
            pos.y -= 0.001f;
        }


        transform.position = pos;
        // Updat epostion from vector
    }
}
