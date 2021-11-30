using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAria : MonoBehaviour
{
    Rigidbody2D rb;
    public static float amiciSaved = 0f;
    public static float posFinalex;

    //public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)&& !GameControllerAria.stop)
        {
            rb.velocity = new Vector2(0f, 7f);
        }
        else if(Input.GetMouseButtonDown(0)&& GameControllerAria.stop)
        {
            rb.velocity = new Vector2(3f, 7f);
        }

        if(rb.transform.position.x<-6.7)
        {
            GameControllerAria.gameover = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            amiciSaved = amiciSaved + 1;
            Destroy(collision.gameObject);
            //Debug.Log(amiciSaved);
        }

        if (collision.gameObject.layer == 8)
        {
            GameControllerAria.success = true;
        }

    }


}
