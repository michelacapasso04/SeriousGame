using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruota : MonoBehaviour
{
    Texture2D t2D;
    Vector2 mousePos = new Vector2();

    RectTransform rect1;
    RectTransform rect2;
    Rigidbody2D ball1;
    Rigidbody2D ball2;
   

    public GameObject RectSX;
    public GameObject RectDX;
    public GameObject freccia;
    public float angoloRotazione;

    Vector2 trans = new Vector2();

    bool Girato = false;
    bool sx = false;
    bool dx = false;
    bool lancio_sx = false;
    bool lancio_dx = false;

    public GameObject gocciaDX;
    public GameObject gocciaSX;
    

    private void Start()

    {

        rect1 = RectSX.GetComponent<RectTransform>();
        rect2 = RectDX.GetComponent<RectTransform>();

        ball1 = gocciaSX.GetComponent<Rigidbody2D>();
        ball2 = gocciaDX.GetComponent<Rigidbody2D>();


    }

    private void Update()
    {

        mousePos = Input.mousePosition;
        mousePos = mousePos.normalized;

        if
          (mousePos.x > rect1.anchorMin.x && mousePos.x < rect1.anchorMax.x &&
            mousePos.y > rect1.anchorMin.y && mousePos.y < rect1.anchorMax.y && !Girato)
        {

            if (Input.GetMouseButton(0))

            {
                // ROTAZIONE A SINISTRA
                float angle1 = Mathf.MoveTowardsAngle(transform.eulerAngles.z, angoloRotazione, 1000 * Time.deltaTime);
                freccia.transform.Rotate(0, 0, angle1, Space.Self);
                gocciaSX.SetActive(true);

                lancio_sx = true;
                Girato = true;
                sx = true;


            }


        }

        else if
               (mousePos.x > rect2.anchorMin.x && mousePos.x < rect2.anchorMax.x &&
                mousePos.y > rect2.anchorMin.y && mousePos.y < rect2.anchorMax.y && !Girato)
        {

            if (Input.GetMouseButton(0)|| Input.touchCount == 1)
            {

                // ROTAZIONE A DESTRA
                float angle2 = Mathf.MoveTowardsAngle(transform.eulerAngles.z, -angoloRotazione, 1000 * Time.deltaTime);
                freccia.transform.Rotate(0, 0, angle2, Space.Self);
                gocciaDX.SetActive(true);

                lancio_dx = true;
                Girato = true;
                dx = true;

            }


        }


        /*
        if (!Input.GetMouseButton(0))
        {


            if (Girato && sx)
            {
                // dalla sinistra torno al centro 
                //float angle3 = Mathf.MoveTowardsAngle(transform.eulerAngles.z, -angoloRotazione, 1000 * Time.deltaTime);

                freccia.transform.rotation = new Quaternion(0, 0, 0, 0);

                Girato = false;
                sx = false;
                gocciaSX.SetActive(false);

            }



            else if (Girato && dx)
            {
                // dalla destra torno al centro 
                //float angle4 = Mathf.MoveTowardsAngle(transform.eulerAngles.z, angoloRotazione, 1000 * Time.deltaTime);
                freccia.transform.rotation = new Quaternion(0, 0, 0, 0);

                Girato = false;
                dx = false;
                gocciaDX.SetActive(false);


            }
        }



        */


            // Controlla come fare ad attivare con il click e non quando è cliccato e poi riposizionare la pallina 

         if (lancio_sx)
            {
                trans.Set(-(0.75f) * 100, 100 * (0.9f));
                ball1.AddForce(trans); 

            }

         if (lancio_dx)
            {
                trans.Set(0.75f * 100, 100 * 1);
                ball2.AddForce(trans);

            }
        
    }
    
          
}
        



    
  


                
            


        

        

        
    



