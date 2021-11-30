using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerTerra : MonoBehaviour
{
    public static bool success = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (success)
        {
            SceneManager.LoadScene("Mostro");
        }
    }
}
