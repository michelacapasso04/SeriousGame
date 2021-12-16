using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeMenager : MonoBehaviour
{

    float timer;
    Text timerText;

// Start is called before the first frame update
void Start()
    {
        timer = 5;
        timerText = GameObject.Find("Tempo").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = "Timer: " + timer.ToString("0");
        }
        else
            Invoke("Inizio",0);



    }

    private void Inizio()
    {

        //ball1 = gocciaSX.GetComponent<Rigidbody2D>();
        //ball2 = gocciaDX.GetComponent<Rigidbody2D>();

        SceneManager.LoadScene("Minigioco Fuoco");

    }
}
