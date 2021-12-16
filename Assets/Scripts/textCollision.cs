using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class textCollision : MonoBehaviour
{
    public GameObject acqua;
    public GameObject fuoco;
    public GameObject button;

    public GameObject goccia;
    public GameObject smoke;
    

    public static int corr = 0;
   

    private void OnTriggerEnter2D(Collider2D collision)

    {
   
        if (collision.gameObject.name == "naturesx" && corr==1) //  HAI INDOVINATO  hard
        {
           
            acqua.SetActive(true);
            // fuoco.SetActive(false);
            button.SetActive(false);

        }

        else if (collision.gameObject.name == "naturedx" && corr==1) // && HAI INDOVINATO soft
        {
            
            acqua.SetActive(true);
           // fuoco.SetActive(false);
            button.SetActive(false);

        }

        if (collision.gameObject.name == "naturesx" && corr==2) //  NON HAI INDOVINATO hard
        {
            smoke.SetActive(true);
        }

        else if (collision.gameObject.name == "naturedx" && corr == 2) // NON HAI INDOVINATO soft
        {
            smoke.SetActive(true);
           
        }




    }


}
