using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scoreacqua : MonoBehaviour
{
    public Text score;


    // Start is called before the first frame update
    void Start()
    {

        score.text = TIMER.punt.ToString();

    }

}
