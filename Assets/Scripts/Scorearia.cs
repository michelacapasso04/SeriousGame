using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scorearia : MonoBehaviour
{
    public Text score;


    // Start is called before the first frame update
    void Start()
    {

        score.text = TimerAria.punt.ToString();

    }

}
