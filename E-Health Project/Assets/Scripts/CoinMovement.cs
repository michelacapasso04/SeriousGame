using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameControllerAria.stop==false)
        {
            transform.localPosition = new Vector2(transform.localPosition.x - 3 * Time.deltaTime, transform.localPosition.y);
        }
        
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
