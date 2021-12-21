using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scoreterra : MonoBehaviour
{
    public Text score;


    // Start is called before the first frame update
    void Start()
    {

        score.text = TimerTerra.punt.ToString();

    }

}