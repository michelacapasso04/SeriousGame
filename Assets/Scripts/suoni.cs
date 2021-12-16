using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public  class suoni : MonoBehaviour
{
        public  AudioSource sc;
        public  AudioSource vit;
        public  AudioSource jump;
        public static int s = 0;
        public static int v = 0;
        public static int j = 0;
        public static string scena;
        public static int via = 0;
        public static int num=0;

        public void Suona()
        {
            //vittoria 
            if (v == 1 && num == 0)
            {
                vit.Play(0);
                StartCoroutine(MyCoroutine());
                MyCoroutine();
                num += 1;
        }
            //sconfitta
            else if (s == 1 && num == 0 )
            {
             
                sc.Play(0);
                StartCoroutine(MyCoroutine());
                MyCoroutine();
                num += 1;
        }

            //jump
            else if (j == 1)
            {
                jump.Play(0);
                num = 0;
                via = 0;
                j = 0;
        }
        }
         IEnumerator MyCoroutine()
        {
            yield return new WaitForSecondsRealtime(2);
            SceneManager.LoadScene(scena);
            num = 0;
            via = 0;
            v = 0;
            s = 0;
        
        }

    public void Update()
    {
        if(via == 1)
        {
            Suona();

        }

    }
    }
