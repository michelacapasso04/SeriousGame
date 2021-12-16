using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int valorepunti;
    void Start()
    {
        valorepunti = 0;
    }
    void Update()
    {
        GetComponent<Text>().text = valorepunti.ToString();
    }
}
