using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowFollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        posMouse.x -= 1.7f;
        posMouse.y += 0.1f;

        transform.position = posMouse;


    }
}