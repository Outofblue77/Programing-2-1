using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //follow mouse position based on screen

        posMouse.x += 2;
        posMouse.y += 0.17f;

        transform.position = posMouse;

    }
}


