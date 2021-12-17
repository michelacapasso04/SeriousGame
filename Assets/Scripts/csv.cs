using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class csv : MonoBehaviour
{
    public struct Entry
    {
        public string cf;
        public string data;
        public string difficoltà;
        public string lettera;
        public string mondo;
        public int score;
        public string nome;
    }

    public List<Entry> entryList = new List<Entry>();
    public Text nomePaz;
    private Transform dataCont;
    private Transform entryTemp;
    public string CF;

    private void Awake()
    {
        dataCont = transform.Find("DataContainer");
        entryTemp = dataCont.Find("EntryTemplate");

        entryTemp.gameObject.SetActive(false); //to hide default template       
    }

    void Start()
    {
        CF = SalvataggioNome.Code;
        UnityEngine.Debug.Log("codice" + CF);

        TextAsset DataCSV = Resources.Load<TextAsset>("db");    

        string[] line = DataCSV.text.Split(new char[] { '\n' });

        for (int i = 1; i < line.Length - 1; i++)
        {
            string[] part = line[i].Split(new char[] { ';' });

            if (part[0] == CF)
            {
                Debug.Log("ciao");
                Entry entry = new Entry();

                entry.data = part[1];

                switch(int.Parse(part[2]))
                {
                    case 1:
                        entry.difficoltà = "FACILE";
                        break;
                    case 2:
                        entry.difficoltà = "MEDIA";
                        break;
                    case 3:
                        entry.difficoltà = "DIFFICILE";
                        break;
                }
                
                switch (int.Parse(part[3]))
                {
                    case 1:
                        entry.lettera = "C";
                        break;
                    case 2:
                        entry.lettera = "G";
                        break;
                    case 3:
                        entry.lettera = "SC";
                        break;
                }
                entry.mondo = part[4];
                int.TryParse(part[5], out entry.score);
                entry.nome = part[6];


                //int target = 1;
                //int diff = 1;

                nomePaz.text = entry.nome;

                entryList.Add(entry);
                Show(entry, dataCont, entryTemp, entryList.Count);
            }
        }
    }

    public void Show(Entry entry, Transform dataCont, Transform entryTemp, int len)
    {
        float templateHeight = 40f;
        Transform entryTransform = Instantiate(entryTemp, dataCont);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * (len-1));
        entryTransform.gameObject.SetActive(true);

        entryTransform.Find("Data").GetComponent<Text>().text = entry.data;
        entryTransform.Find("Difficoltà").GetComponent<Text>().text = entry.difficoltà;
        entryTransform.Find("Lettera").GetComponent<Text>().text = entry.lettera;
        entryTransform.Find("Mondo").GetComponent<Text>().text = entry.mondo;
        entryTransform.Find("Score").GetComponent<Text>().text = entry.score.ToString();
    }
}

