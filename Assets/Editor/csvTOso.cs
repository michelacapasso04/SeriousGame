using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class csvTOso
{
  private static string cardCSVPath = "/Editor/Parole.csv";
  [MenuItem("Utilities/Generate Cards")]
  public static void GenerateCards()
  {
    string[] allLines = File.ReadAllLines(Application.dataPath + cardCSVPath);

    foreach (string s in allLines)
    {
      string[] splitData = s.Split(',');

      Card card = ScriptableObject.CreateInstance<Card>();
      card.indice = int.Parse(splitData[0]);
      card.parolaEssenziale = float.Parse(splitData[1]);
      card.rappresentabile = int.Parse(splitData[2]);
      card.parola = splitData[3];
      card.lett1 = splitData[4];
      card.sillaba1 = splitData[5];
      card.hard = int.Parse(splitData[6]);
      card.soft = int.Parse(splitData[7]);
	  card.img = Resources.Load<Sprite>($"Immagini/{card.parola}");
	  card.suono = Resources.Load<AudioClip>($"Suoni/{card.parola}");
		
	  AssetDatabase.CreateAsset(card, $"Assets/Resources/Cards/{card.parola}.asset");

    }
    AssetDatabase.SaveAssets();
  }
}