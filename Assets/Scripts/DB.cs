using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.IO.Path;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using System.Globalization;


public class DB : MonoBehaviour

{
    private int punteggio;
    // Start is called before the first sframe update
    void Start()
    {
        string fileName = "Resources/db.csv";
        string filePath = System.IO.Path.Combine(Application.dataPath, fileName);
        //string filePath = "C:/Users/HP/Desktop/MIA_VITA/giocondosalvailmondo/Assets/Resources/db.csv";
        List<string> csvLines = new List<string>();

        // start:

        //System.IO.File.AppendAllText(filePath, $"\"cf\";\"data\";\"diff\";\"target\";\"mondo\";\"punteggio\";\"nome\";" + Environment.NewLine);

        var writer = System.IO.File.AppendText(filePath);// creates writer object (file lock)

        
        // add data entries:
        string cf = SalvataggioNome.Code;
        cf=cf.ToUpper();
        string nome = SalvataggioNome.Name;
        nome=nome.ToUpper();
        string data = DateTime.Today.ToString("d");
        int target = ChangeScene.target_selezionato;
        int diff = ChangeScene.sound_selezionato;
        string mondo = ChangeScene.mondo;
        if(mondo == "FUOCO")
        {
            punteggio = Answer_Fuoco.corretto;
        } 
        else if (mondo == "ARIA")
        {
            punteggio = Answer_Aria.corretto;
        }
        else if (mondo == "ACQUA")
        {
            punteggio = Answer_Acqua.corretto;
        }
        else if (mondo == "TERRA")
        {
            punteggio = Answer_Terra.corretto;
        }


        string riga = $"{cf};{data};{diff};{target};{mondo};{punteggio};{nome};";
        csvLines.Add(riga);
        writer.WriteLine(csvLines[0]);
        

        // end, release file locks:
        writer.Close();
    }

    
}
