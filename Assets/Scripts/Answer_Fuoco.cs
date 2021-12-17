using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Answer_Fuoco : MonoBehaviour
{
    public static int corretto;
    public Text ris;
    public static float scritta = 5.0f;
    


    public void Soft()
    {
        //se file con nome card è soft allora corretto+=1
        if (DB2.GetCardByID(CardManager.indice).soft == 1)
        {
            corretto += 1;
            textCollision.corr = 1;
            ris.text = (scritta).ToString("COMPLIMENTI!");
        }
        else
        {
            textCollision.corr = 2;
            ris.text = (scritta).ToString("OH NO!");
        }
        TimerFuoco.timeLeft = 999.0f;
        StartCoroutine(MyCoroutine());
        MyCoroutine();
    }

    public void Hard()
    {
        //se file con nome card è hard allora corretto+=1
        if (DB2.GetCardByID(CardManager.indice).hard == 1)
        {
            corretto += 1;
            textCollision.corr = 1;
            ris.text = (scritta).ToString("COMPLIMENTI!");
        }
        else
        {
            textCollision.corr = 2;
            ris.text = (scritta).ToString("OH NO!");
        }
        TimerFuoco.timeLeft = 999.0f;
        StartCoroutine(MyCoroutine());
        MyCoroutine();
    }


    IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        SceneManager.LoadScene("Minigioco Fuoco");
        TimerFuoco.num = TimerFuoco.num - 1;
        TimerFuoco.timeLeft = 5.0f;
        textCollision.corr = 0;
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
        CardManager.v_count = 0;
        CardManager.s_count = 0;
    }

}
