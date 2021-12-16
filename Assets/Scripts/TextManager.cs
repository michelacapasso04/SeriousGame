using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public GameObject textBox;
    public Text theText;
    public TextAsset textFile;
    public string[] textLines;
    public int currentLine;
    public int endLine;
    
    public void Continue()
    {
        
        if (currentLine>=endLine)
        {
            SceneManager.LoadScene(7);
        }
        else
        {
            currentLine += 1;
        }

    }

    void Start()
    {
        if(textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }
        if(endLine == 0)
        {
            endLine = textLines.Length - 1;
        }
    }
    
    void Update()
    {
        theText.text = textLines[currentLine];
    }
}

