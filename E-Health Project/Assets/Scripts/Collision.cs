using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{

    //COLLISIONE DELL'AVATAR
    private void OnTriggerEnter2D(Collider2D coll)
	{
		SceneManager.LoadScene("Game Over Acqua");
	}
}
