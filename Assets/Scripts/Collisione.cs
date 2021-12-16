using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collisione : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Counter.valorepunti += 1;
            Destroy(collision.gameObject);
            //Debug.Log(amiciSaved);
        }

        if (collision.gameObject.layer == 8 && Counter.valorepunti >= 4)
        {
            GameControllerTerra.success = true;
        }

        if (collision.gameObject.layer == 8 && Counter.valorepunti < 4)
        {
            GameControllerTerra.gameover = true;
        
        }

    }
}