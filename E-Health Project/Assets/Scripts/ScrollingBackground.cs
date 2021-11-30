using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;


public class ScrollingBackground : MonoBehaviour
{
    public float speed;
    


    // Update is called once per frame
    private void Update()
    {
        transform.Translate(translation: Vector2.left * (speed * Time.deltaTime));

        if (transform.position.x <= -102f)
        {
            transform.position = new Vector2(x: -102f,transform.position.y);
        }
        
    }
}
