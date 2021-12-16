using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sfida_squalo : MonoBehaviour
{
    public void Sfida()
	{
		Answer_Acqua.corretto = 0;
		SceneManager.LoadScene("Minigioco Acqua");
	
	}
}
