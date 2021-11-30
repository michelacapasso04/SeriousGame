using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubottiMovement : MonoBehaviour
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
            transform.localPosition = new Vector3(transform.localPosition.x - 3 * Time.deltaTime, transform.localPosition.y, 1460f);
        }
        
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
