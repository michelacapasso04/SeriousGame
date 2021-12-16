using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerFuoco : MonoBehaviour
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
                startText.fontSize = 80;
                startText.text = (timeLeft).ToString("tempo scaduto");
                StartCoroutine(MyCoroutine());
                MyCoroutine();
            }
        }
        else
        {
            if (Answer_Fuoco.corretto > 5)
            {
                SceneManager.LoadScene("Vittoria Fuoco");
                DontDestroy.music.Play(0);
            }
            else
            {
                SceneManager.LoadScene("Sconfitta Fuoco");
                DontDestroy.music.Play(0);
            }
        }

    }
    IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        print(num);
        num = num - 1;
        timeLeft = 5.0f;
        SceneManager.LoadScene("Minigioco Fuoco");
     

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
