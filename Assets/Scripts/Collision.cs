using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
	 public AudioSource audioerrore;
    //COLLISIONE DELL'AVATAR
    private void OnTriggerEnter2D(Collider2D coll)
	{
		ScrollingBackground.speed = 0;
        audioerrore.Play(0);
		StartCoroutine(MyCoroutine());
        MyCoroutine();
	}

	IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene("Game Over Acqua");
    }
}
