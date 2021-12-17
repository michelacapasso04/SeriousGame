using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class Sound : MonoBehaviour
{
    Toggle myToggle;
    public static bool nosound = false;

    // Start is called before the first frame update
    void Start()
    {
        myToggle = GetComponent<Toggle>();
        if(nosound==true)
        {
            myToggle.isOn = false;
        }
    }

    public void ToggleAudioOnValueChange(bool audioIn)
    {
        if(audioIn)
        {
            AudioListener.volume = 1;
            DontDestroy.music.Play();
            nosound = false;
        }
        else
        {
            //AudioListener.volume = 0;
            DontDestroy.music.Pause();
            nosound = true;
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
