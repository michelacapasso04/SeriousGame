using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionShark : MonoBehaviour
{ 
	public GameObject avatar;


	//COLLISIONE DELL'AVATAR
	private void OnTriggerEnter2D(Collider2D coll)
	{
		avatar.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -1, 0), 3);
		AvatarMovement.val = false;
	}
}
