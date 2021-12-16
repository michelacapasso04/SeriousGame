using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Database", menuName = "Assets/Database")]
public class Database : ScriptableObject
{
    public List<Card> allCards;
}