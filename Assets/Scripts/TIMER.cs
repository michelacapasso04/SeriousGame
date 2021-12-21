using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TIMER : MonoBehaviour
{

    public static float timeLeft = 5.0f;
    public Text startText;
    public static int tempo;
    public static int num = 10;
    public static float punt = 0.0f;

    void Update()
        {  
            if(num>0)
            {
            if (timeLeft == 999.0f)
            {

            }
                else if (timeLeft > 0)
                {
                    timeLeft -= Time.deltaTime;
                    startText.text = (timeLeft).ToString("0");
                    tempo = int.Parse(startText.text);
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
                if (Answer_Acqua.corretto > 5.0f)
                {
                    SceneManager.LoadScene("Vittoria Acqua");
                    num = 10;
                    punt = Answer_Acqua.corretto;
                    Answer_Acqua.corretto = 0.0f;
                    DontDestroy.music.Play(0);
            }
                else
                {
                    SceneManager.LoadScene("Sconfitta Acqua");
                    num = 10;
                    punt = Answer_Acqua.corretto;
                    Answer_Acqua.corretto = 0.0f;
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
        SceneManager.LoadScene("Minigioco Acqua");
        
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
