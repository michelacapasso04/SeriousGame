using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DB2 : MonoBehaviour
{
    public Database items;
    public static DB2 instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static Card GetCardByID(int ID)
    {
        return instance.items.allCards.FirstOrDefault(i => i.indice == ID); //cerca indice nel database
    }
}

// 16 minuti secondo video