using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerTerra : MonoBehaviour
{
    public static bool success;
    public static bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        success = false;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            suoni.via = 1;
            suoni.s = 1;
            suoni.scena = "Game Over Terra";
            
        }

        if (success)
        {
            Answer_Terra.corretto = 0;
            suoni.via = 1;
            suoni.v = 1;
            suoni.scena = "Fine Terra";
            
        }
    }
}