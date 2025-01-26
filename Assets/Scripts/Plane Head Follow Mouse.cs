using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHeadFollowMouse : MonoBehaviour
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

        posMouse.x -=  1.8f;
        //Adjustment to stay slightly off

        transform.position = posMouse;
        // Update position based from variable

    }
}
