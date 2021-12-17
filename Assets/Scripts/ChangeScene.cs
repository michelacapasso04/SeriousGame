using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    static public int target_selezionato = 0;
    static public int sound_selezionato = 0;
    static public string mondo;
    public void CambiaScena (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Easy()
    {
        target_selezionato = 1;
        SceneManager.LoadScene("Ultima Specialista");
    }

    public void Medium()
    {
        target_selezionato = 2;
        SceneManager.LoadScene("Ultima Specialista");
    }

    public void Hard()
    {
        target_selezionato = 3;
        SceneManager.LoadScene("Ultima Specialista");
    }

    public void C()
    {
        sound_selezionato = 1;
        SceneManager.LoadScene("Target Selection");
    }

    public void G()
    {
        sound_selezionato = 2;
        SceneManager.LoadScene("Target Selection");
    }

    public void SC()
    {
        sound_selezionato = 3;
        SceneManager.LoadScene("Target Selection");
    }

    public void FUOCO()
    {
        mondo = "FUOCO";
        SceneManager.LoadScene("Spiegazione Livello Fuoco");
    }

    public void ARIA()
    {
        mondo = "ARIA";
        SceneManager.LoadScene("Spiegazione Livello Aria");
    }

    public void ACQUA()
    {
        mondo = "ACQUA";
        SceneManager.LoadScene("Spiegazione Livello Acqua");
    }

    public void TERRA()
    {
        mondo = "TERRA";
        SceneManager.LoadScene("Spiegazione Livello Terra");
    }


}
