using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pavimento : MonoBehaviour
{
    Vector2 posIniziale;
    // Start is called before the first frame update
    void Start()
    {
        posIniziale = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x>=-4f && GameControllerAria.stop==false)
        {
            transform.localPosition = new Vector2(transform.localPosition.x - 3*Time.deltaTime, transform.localPosition.y);
        }
        else
        {
            transform.localPosition = posIniziale;
        }
        
    }
}
