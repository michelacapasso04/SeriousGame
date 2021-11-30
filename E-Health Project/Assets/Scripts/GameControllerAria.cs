using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerAria : MonoBehaviour
{
    float spawnTimer;
    float spawnRate = 3f;


    public GameObject nuvole;
    public GameObject amico1;
    public GameObject amico2;
    public GameObject amico3;
    public GameObject amico4;
    public GameObject amico5;
    public GameObject nemico;

    public static bool gameover=false;
    public static bool stop = false;
    public static bool success = false;

    private float counter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            spawnTimer += Time.deltaTime;

            if (spawnTimer >= spawnRate)
            {
                spawnTimer -= spawnRate;
                Vector2 spawnPos = new Vector2(7f, Random.Range(-2.5f, 1.2f));
                Instantiate(nuvole, spawnPos, Quaternion.identity);

                spawnPos.x = spawnPos.x + 1.8f;
                if (counter == 0)
                {
                    spawnPos.y = spawnPos.y + 3f;
                    Instantiate(amico1, spawnPos, Quaternion.identity);
                    counter = counter + 1;
                }
                else if (counter == 1)
                {
                    spawnPos.y = spawnPos.y + 3f;
                    Instantiate(amico2, spawnPos, Quaternion.identity);
                    counter = counter + 1;
                }
                else if (counter == 2)
                {
                    spawnPos.y = spawnPos.y + 3f;
                    Instantiate(amico3, spawnPos, Quaternion.identity);
                    counter = counter + 1;
                }
                else if (counter == 3)
                {
                    spawnPos.y = spawnPos.y + 3f;
                    Instantiate(amico4, spawnPos, Quaternion.identity);
                    counter = counter + 1;
                }
                else if (counter == 4)
                {
                    spawnPos.y = spawnPos.y + 3f;
                    Instantiate(amico5, spawnPos, Quaternion.identity);
                    counter = counter - 4;
                }

            }
        }

        if (PlayerAria.amiciSaved == 5 && !stop)
        {
            Vector2 spawnPos1 = new Vector2(10f, 0f);
            Instantiate(nemico, spawnPos1, Quaternion.identity);
            stop = true;
        }


        if (gameover)
        {
            SceneManager.LoadScene(10);
        }
        if (success)
        {
            SceneManager.LoadScene(11);
        }

    }

}
