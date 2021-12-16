using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class CardManager : MonoBehaviour
{
	public Text word;
	public Image img;
	public AudioSource sound;
	public float timeleft;
	private int randomInt;
	private int nCard;
	private List<int> indx = new List<int>();
	public static int visual; //visualizzazione 0 = vedere, 1 = sentire
	public static int v_count=0, s_count=0;
	public static int indice;
	private int lettera; //da mettere lettera selezionata nel menu (1 = c, 2 = g, 3 = sc)
	private int diffic; //da mettere difficoltà selezionata nel menu (1 facile e a salire)


	void Awake()
	{
		diffic = 3;
		lettera = 3;
		/*diffic = ChangeScene.target_selezionato;
		lettera = ChangeScene.sound_selezionato;*/
		UnityEngine.Debug.Log("difficoltà"+diffic);
		UnityEngine.Debug.Log("lettera"+lettera);
	}

	void Start()
	{
		indx = FirstLetter(lettera);
		StartCoroutine(cor());
	}

	IEnumerator cor()
	{
		for (nCard = 0; nCard < 10; nCard++)
		{
			randomInt = RandomInt(indx);
			Difficulty(diffic);
			yield return new WaitForSeconds(timeleft);
		}
	}


	public List<int> FirstLetter(int lettera)
	{
		switch (lettera)
		{
			case 1: //lettera c
				ChoseLetter("c");
				break;
			case 2: //lettera c
				ChoseLetter("g");
				break;
			case 3: //lettera c
				ChoseLetter("s");
				break;
		}
		return indx;
	}

	public void ChoseLetter(string lett)
	{
		foreach (Card i in DB2.instance.items.allCards)
		{
			if (i.lett1 == lett)
			{
				indx.Add(i.indice);
			}
		}
	}

	public int RandomInt(List<int> indx)
	{
		randomInt = Random.Range(0, DB2.instance.items.allCards.Count());
		while (!(indx.Contains(randomInt)))
		{
			randomInt = Random.Range(0, DB2.instance.items.allCards.Count());
		}
		indice = randomInt;
		return randomInt;
	}

	public void Difficulty(int diffic)
	{
		switch (diffic)
		{
			case 1: //facile 90% visual=0=vedere
				Show(9, 1);
				break;
			case 2: //media 70% visual=0=vedere
				Show(7, 3);
				break;
			case 3: //difficile 50% visual=0=vedere
				Show(5, 5);
				break;
		}
	}

	public void Show(int vedo, int sento)
	{
		if (v_count + s_count < 10)
		{
			UnityEngine.Debug.Log(v_count + "v_count");
			UnityEngine.Debug.Log(s_count + "s_count");
			if (v_count == vedo)
			{
				visual = 1;
			}
			else if (s_count == sento)
			{
				visual = 0;
			}
			else
			{
				visual = Random.Range(0, 2);
			}
			GetCardByID(visual);
			/*if (visual == 0)
			{
				v_count++;
			}
			else if (visual == 1)
			{
				s_count++;
			}
			*/
		}
	}

	public void GetCardByID(int visual)
	{
		switch (visual)
		{
			case 0:
				SeeCard(DB2.GetCardByID(randomInt));
				break;
			case 1:
				HearCard(DB2.GetCardByID(randomInt));
				break;
		}
	}

	private void SeeCard(Card i)
	{
		word.text = i.parola;
		img.sprite = i.img;
	}

	private void HearCard(Card i)
	{
		word.text = "...";
		img.sprite = i.img;
		sound.clip = i.suono;
		sound.Play();
	}
}