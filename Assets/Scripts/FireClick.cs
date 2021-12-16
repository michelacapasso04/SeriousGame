using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireClick : MonoBehaviour
{

    public GameObject freccia;
    Rigidbody2D ball;
   

    public float angoloRotazione;

    Vector2 trans = new Vector2();

    bool Girato = false;

    bool lancio_sx = false;
    bool lancio_dx = false;
    public bool lato ; //0 per sinistra 1 per destra

    public GameObject goccia;
   

    public Button button;
   




    // Start is called before the first frame update
    void Start()
    {
        ball = goccia.GetComponent<Rigidbody2D>();
        button.onClick.AddListener(Ruota);
        
    }

    private void Ruota()
    {
        if (!lato)
        {
            // ROTAZIONE A SINISTRA
            float angle1 = Mathf.MoveTowardsAngle(transform.eulerAngles.z, angoloRotazione, 1000 * Time.deltaTime);
            freccia.transform.Rotate(0, 0, angle1, Space.Self);
            goccia.SetActive(true);

            lancio_sx = true;
            Girato = true;

        }
        else if (lato)
        {
            // ROTAZIONE A DESTRA
            float angle2 = Mathf.MoveTowardsAngle(transform.eulerAngles.z, -angoloRotazione, 1000 * Time.deltaTime);
            freccia.transform.Rotate(0, 0, angle2, Space.Self);
            goccia.SetActive(true);

            lancio_dx = true;
            Girato = true;
        }
       


    }


    // Update is called once per frame
    void Update()
    {
        if (lancio_sx)
        {
            trans.Set(-(0.75f) * 100, 100 * (0.9f));
            ball.AddForce(trans);

        }

        else if (lancio_dx)
        {
            trans.Set(0.75f * 100, 100 * 1);
            ball.AddForce(trans);

        }
    }
}
