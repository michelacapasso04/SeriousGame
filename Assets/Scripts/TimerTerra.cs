using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerTerra : MonoBehaviour
{
    public static float timeLeft = 5.0f;
    public Text startText;
    public static int num = 10;


    void Update()
    {
        if (num > 0)
        {
            if (timeLeft == 999.0f)
            {

            }
            else if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                startText.text = (timeLeft).ToString("0");
            }
            else if (timeLeft < 0)
            {
                startText.fontSize = 50;
                startText.text = (timeLeft).ToString("tempo scaduto");
                StartCoroutine(MyCoroutine());
                MyCoroutine();
            }
        }
        else
        {
            if (Answer_Terra.corretto > 5)
            {
                SceneManager.LoadScene("Vittoria Terra");
                DontDestroy.music.Play(0);
            }
            else
            {
                SceneManager.LoadScene("Sconfitta Terra");
                DontDestroy.music.Play(0);
            }
        }

    }
    IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(2);
        print(num);
        num = num - 1;
        timeLeft = 5.0f;
        SceneManager.LoadScene("Minigioco Terra");
        if (CardManager.visual == 0)
        {
            CardManager.v_count++;
        }
        else if (CardManager.visual == 1)
        {
            CardManager.s_count++;
        }

    }

}