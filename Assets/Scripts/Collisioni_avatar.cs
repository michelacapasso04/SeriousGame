using UnityEngine;

public class Collisione_fuoco : MonoBehaviour
{
    public BckGndMov mov;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("fire"))
        {

            // cosa faccio se collide??
            mov.enabled = false; 
        }
    }
}
