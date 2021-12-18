using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sfida_squalo : MonoBehaviour
{
    public void Sfida()
	{
		CardManager.v_count = 0;
		CardManager.s_count = 0;
		CardManager.indList = new List<int>();
		Answer_Acqua.corretto = 0;
		SceneManager.LoadScene("Minigioco Acqua");
	
	}
}
