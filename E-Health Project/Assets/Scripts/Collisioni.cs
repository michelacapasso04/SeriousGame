using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisioni : MonoBehaviour
{
    public BckGndMov mov;
    public GameObject end ;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("fire"))
        {

            // cosa faccio se collide??
            mov.enabled = false;
            //end.SetActive(true);
            SceneManager.LoadScene("Game Over Fuoco");
        }

    }

}
