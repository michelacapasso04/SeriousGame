using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Assets/New Card")]
public class Card : ScriptableObject
{
    public int indice;
    public float parolaEssenziale;
    public int rappresentabile;
    public string parola;
    public string lett1;
    public string sillaba1;
    public int hard;
    public int soft;
    public Sprite img;
    public AudioClip suono;
}