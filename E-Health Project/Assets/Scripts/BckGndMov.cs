using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;


public class BckGndMov : MonoBehaviour
{
    public float speed;
   
    
    public GameObject bck2;


    // Update is called once per frame
    private void Update()
    {
        if (Camera.main.transform.position.x < bck2.transform.position.x)
        { // scena finale


            transform.Translate(translation: Vector2.left * (speed * Time.deltaTime));
        }

        else //if ( Camera.main.transform.position.x > transform.position.x) // scena finale
        {
            return;
        }
        
           
        
     }
}