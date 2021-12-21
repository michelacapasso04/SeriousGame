using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Answer_Terra : MonoBehaviour
{
    public static float corretto;
    public Text ris;
    public static float scritta = 5.0f;


    public void Soft()
    {
        //se file con nome card è soft allora corretto+=1
        if (DB2.GetCardByID(CardManager.indice).soft == 1)
        {

            if (TimerTerra.tempo == 5 || TimerTerra.tempo == 4)
            {
                corretto += 1.0f;
            }
            else if (TimerTerra.tempo == 3)
            {
                corretto += 0.9f;
            }
            else if (TimerTerra.tempo == 2)
            {
                corretto += 0.8f;
            }
            else if (TimerTerra.tempo == 1)
            {
                corretto += 0.7f;
            }
            ris.text = (scritta).ToString("COMPLIMENTI!");
            //Destroy(this);
        }
        else
        {
            ris.text = (scritta).ToString("OH NO!");
            //Destroy(this);
        }
        TimerTerra.timeLeft = 999.0f;
        StartCoroutine(MyCoroutine());
        MyCoroutine();
    }

    public void Hard()
    {
        //se file con nome card è hard allora corretto+=1
        if (DB2.GetCardByID(CardManager.indice).hard == 1)
        {
            if (TimerTerra.tempo == 5 || TimerTerra.tempo == 4)
            {
                corretto += 1.0f;
            }
            else if (TimerTerra.tempo == 3)
            {
                corretto += 0.9f;
            }
            else if (TimerTerra.tempo == 2)
            {
                corretto += 0.8f;
            }
            else if (TimerTerra.tempo == 1)
            {
                corretto += 0.7f;
            }
            ris.text = (scritta).ToString("COMPLIMENTI!");
            //Destroy(this);
        }
        else
        {
            ris.text = (scritta).ToString("OH NO!");
            //Destroy(this);
        }
        TimerTerra.timeLeft = 999.0f;
        StartCoroutine(MyCoroutine());
        MyCoroutine();
    }


    IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        SceneManager.LoadScene("Minigioco Terra");
        TimerTerra.num = TimerTerra.num - 1;
        TimerTerra.timeLeft = 5.0f;
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
