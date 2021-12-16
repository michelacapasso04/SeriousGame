using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scoreacqua : MonoBehaviour
{
    public Text score;
    public static float s = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        score.text = (s).ToString(Answer_Acqua.corretto.ToString());
    }

}
