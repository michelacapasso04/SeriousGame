using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using System.Globalization;

public class SalvataggioNome : MonoBehaviour
{
    public static Dictionary<string, string> dictionary = new Dictionary<string, string>();
    public static List<string> dictionaryName = new List<string>();
    public static List<string> dictionaryCF = new List<string>();
    public static string kidName = "Name";
    public static string CF = "CF";
    public static string Name;
    public static string Code;
    public GameObject inputFieldName;
    public GameObject inputFieldCF;

    public void Avanti()
    {
        Name = inputFieldName.GetComponent<Text>().text;
        dictionaryName.Add(Name);
        Code = inputFieldCF.GetComponent<Text>().text;
        dictionaryCF.Add(Code);
        SceneManager.LoadScene("Sound Selection");
    }

    private void SaveToFile(List<string> results, string filename)
    {
        string[] lines = new string[results.Count];
        for (int i = 0; i < results.Count; ++i)
            lines[i] = results[i];
        // Write the lines into the file
        string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
        File.WriteAllLines(path + "/" + filename, lines);
        

    }

    public void Statistiche()
    {
        Name = (inputFieldName.GetComponent<Text>().text).ToUpper();
        Code = (inputFieldCF.GetComponent<Text>().text).ToUpper();
        SceneManager.LoadScene("Statistiche");
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
