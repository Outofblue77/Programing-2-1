using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : MonoBehaviour
{
   
    public float speed = 0.007f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x -= speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x > Screen.width + 25)
        {
            pos.x = +15;

        }

        transform.position = pos;
    }
}
