using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>-10.5f)
        {
            transform.localPosition = new Vector2(transform.localPosition.x - 2 * Time.deltaTime, transform.localPosition.y);
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
}
