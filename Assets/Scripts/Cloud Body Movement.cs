using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBodymoevment : MonoBehaviour
{
    public float speed = 0.005f;
    // speed variable to edit from unity

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x += speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x > Screen.width + 25) // Loop to make clouds go back when they passa point
        {
            pos.x = -15;
            //Replace cloud back to left side to replay animation
        }

        transform.position = pos;
        // Update position based from variable
    }
}

