using System;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

// public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta);

public class avatar_jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10;
    public float h ;
    bool isSaltoRilasciato = true;
    private bool pavimento;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pavimento = true;
    }
    private void Update()
    {
        float movX= rb.velocity.x;
        float movY = rb.velocity.y;
        rb.velocity = new Vector2(movX, movY);

        if(Input.GetMouseButton(0) && isSaltoRilasciato && pavimento)
        {
            rb.AddForce(Vector2.up*h, ForceMode2D.Impulse);
            isSaltoRilasciato = false;
            pavimento = false;
            suoni.via = 1;
            suoni.j = 1;
        }
        else if (!isSaltoRilasciato && !Input.GetMouseButton(0))
        {
            isSaltoRilasciato = true;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        pavimento = true;
    }

}



    

    
  
    




