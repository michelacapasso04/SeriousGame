using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Answer_Aria : MonoBehaviour
{
    public static int corretto = 0;
    public Text ris;
    public static float scritta = 5.0f;


    public void Soft()
    {
        //se file con nome card ? soft allora corretto+=1
        if (DB2.GetCardByID(CardManager.indice).soft == 1)
        {
            corretto += 1;
            ris.text = (scritta).ToString("COMPLIMENTI!");
        }
        else
        {
            ris.text = (scritta).ToString("OH NO!");
        }
        TimerAria.timeLeft = 999.0f;
        StartCoroutine(MyCoroutine());
        MyCoroutine();
    }

    public void Hard()
    {
        //se file con nome card ? hard allora corretto+=1
        if (DB2.GetCardByID(CardManager.indice).hard == 1)
        {
            corretto += 1;
            ris.text = (scritta).ToString("COMPLIMENTI!");
        }
        else
        {
            ris.text = (scritta).ToString("OH NO!");
        }
        TimerAria.timeLeft = 999.0f;
        StartCoroutine(MyCoroutine());
        MyCoroutine();
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        SceneManager.LoadScene("Minigioco Aria");
        TimerAria.num = TimerAria.num - 1;
        TimerAria.timeLeft = 5.0f;
        if (CardManager.visual == 0)
        {
            CardManager.v_count++;
        }
        else if (CardManager.visual == 1)
        {
            CardManager.s_count++;
        }
        CardManager.indList.Add(CardManager.indice);
    }

    public void Start()
    {
        DontDestroy.music.Pause();
    }



}






