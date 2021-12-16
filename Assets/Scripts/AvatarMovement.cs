using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMovement : MonoBehaviour
{
	public int Velocita_di_movimento;
	public static bool val = true;
	public float maxy;
	public float miny;
	private void Update()
	{
		// Se � premuto il testo sinistro del mouse
		if (Input.GetMouseButton(0) & val)
		{
			// Inserisco la posizione del mouse sul mondo di gioco in una variabile
			Vector3 PosizioneToccoMouse = Camera.main.ScreenToWorldPoint(new Vector3(-5, Input.mousePosition.y, Camera.main.nearClipPlane));
			// Imposto una variabile per la velocit�
			if (PosizioneToccoMouse.y > miny & PosizioneToccoMouse.y < maxy)
			{
				float Velocita = Velocita_di_movimento * Time.deltaTime;
				// Muovo l'oggetto dello script verso la posizione del mouse toccata sullo schermo
				transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5, PosizioneToccoMouse.y, 0), Velocita);
			}
		}

		// Se si tocca lo schermo
		if (Input.touchCount > 0 & val)
		{
			// Inserisco il tocco in una variabile
			Touch touch = Input.GetTouch(0);
			// Se il dito � sullo schermo....
			if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
			{
				// Inserisco la posizione del tocco sul mondo di gioco in una variabile
				Vector3 PosizioneTouch = Camera.main.ScreenToWorldPoint(new Vector3(-5, touch.position.y, Camera.main.nearClipPlane));
				// Imposto una variabile per la velocit�
				if (PosizioneTouch.y > miny & PosizioneTouch.y < maxy)
				{
					float Velocita = Velocita_di_movimento * Time.deltaTime;
					// Muovo il personaggio verso il punto dove tocca il dito
					transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5, PosizioneTouch.y, 0), Velocita);
				}
			}
		}



	}


}