using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentoMinigiocoAria : MonoBehaviour
{
    private Vector2 posIniziale;
    public int Velocita_di_movimento;
    // answer=1 soft answer=2 hard answer=0 null
    public static int answer;
    // Start is called before the first frame update
    void Start()
    {
        posIniziale = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x < 1299f)
        {
            transform.localPosition = new Vector2(transform.localPosition.x + 600 * Time.deltaTime, transform.localPosition.y);
            /*
             if (Input.GetMouseButton(0))
            {
                // Inserisco la posizione del mouse sul mondo di gioco in una variabile
                Vector2 PosizioneToccoMouse = Camera.main.ScreenToWorldPoint(new Vector2(-5f, Input.mousePosition.y));
                // Imposto una variabile per la velocità
                float Velocita = Velocita_di_movimento * Time.deltaTime;
                // Muovo l'oggetto dello script verso la posizione del mouse toccata sullo schermo
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(transform.localPosition.x, PosizioneToccoMouse.y), Velocita);
            }
            */
        }
        else 
        {
            Destroy(this);
        }
        Debug.Log(Answer_Aria.corretto);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            //se file con nome card è soft allora corretto+=1
            Answer_Aria.corretto += 1;
            SceneManager.LoadScene("Minigioco Aria");
            TIMER.num = TIMER.num - 1;
        }

        else if (collision.gameObject.layer == 10)
        {
            //se file con nome card è hard allora corretto+=1
            Answer_Aria.corretto -= 1;
            SceneManager.LoadScene("Minigioco Aria");
            TIMER.num = TIMER.num - 1;
        }

        else
        {
            Answer_Aria.corretto = 0;
            TIMER.num = 10;
            SceneManager.LoadScene("Minigioco Aria");
        }

        
    }
}

