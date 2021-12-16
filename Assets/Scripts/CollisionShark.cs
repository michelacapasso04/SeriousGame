using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionShark : MonoBehaviour
{ 
	public GameObject avatar;
	public AudioSource audiovittoria;

	//COLLISIONE DELL'AVATAR
	private void OnTriggerEnter2D(Collider2D coll)
	{
		avatar.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -1, 0), 3);
		AvatarMovement.val = false;
		audiovittoria.Play(0);
		StartCoroutine(MyCoroutine());
        MyCoroutine();
	}

	IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene("Fine Acqua");
    }
}
