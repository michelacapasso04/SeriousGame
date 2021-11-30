using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    private Rigidbody2D myBody;

    private float speed = 1.5f;

    private bool moveLeft;
    private bool moveUp;
    private bool dontMoveH;
    private bool dontMoveV;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        dontMoveH = true;
        dontMoveV = true;
    }
    
    void Update()
    {
        HandleMoving();
    }

    void HandleMoving()
    {
        if (dontMoveH)
        {
            StopMoving();
        }
        else
        {
            if (moveLeft)
            {
                MoveLeft();
            }
            else if (!moveLeft)
            {
                MoveRight();
            }
        }
        
        if (dontMoveV)
        {
            StopMovingUD();
        }
        else
        {
            if (moveUp)
            {
                MoveUp();
            }
            else if (!moveUp)
            {
                MoveDown();
            }
        }
    }

    public void AllowMovement(bool movement)
    {
        dontMoveH = false;
        moveLeft = movement;
    }
    
    public void AllowMovementUD(bool movement)
    {
        dontMoveV = false;
        moveUp = movement;
    }

    public void DontAllowMovement()
    {
        dontMoveH = true;
    }
    
    public void DontAllowMovementUD()
    {
        dontMoveV = true;
    }

    public void MoveLeft()
    {
        myBody.velocity = new Vector2(-speed, myBody.velocity.y);
    }
    
    public void MoveRight()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }
    
    public void MoveUp()
    {
        myBody.velocity = new Vector2(myBody.velocity.x, -speed);
    }
    
    public void MoveDown()
    {
        myBody.velocity = new Vector2(myBody.velocity.x, speed);
    }

    public void StopMoving()
    {
        myBody.velocity = new Vector2(0f, myBody.velocity.y);
    }
    
    public void StopMovingUD()
    {
        myBody.velocity = new Vector2(myBody.velocity.x, 0f);
    }

    void DetectInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if (x > 0)
        {
            MoveRight();
        } else if (x < 0)
        {
            MoveLeft();
        } else if (y < 0)
        {
            MoveDown();
        } else if (y > 0)
        {
            MoveUp();
        } 
        else
        {
            StopMoving();
            StopMovingUD();
        }
    }
}
