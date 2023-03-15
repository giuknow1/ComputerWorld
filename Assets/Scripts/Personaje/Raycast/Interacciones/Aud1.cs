using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Aud1 : Audio
{
    public  bool rep = true;
    public  bool control = false;
    public GameObject subtitles;

    public override void Audio1()
    {
       

        if ((rep) && (control == false))
        {

            control = true;
            GestorDeAudio.instancia.ReproducirSonido("Radio Boton");

            GestorDeAudio.instancia.ReproducirSonido("Audio1");

            StartCoroutine(audio1());
            StartCoroutine(Wait());
            StartCoroutine(Subtitles());

        }

    }

    IEnumerator audio1()
    {
        yield return new WaitForSeconds(12f);
        control = false;
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.25f);
        subtitles.SetActive(true);
    }

    IEnumerator Subtitles()
    {
        yield return new WaitForSeconds(11f);
        subtitles.SetActive(false);
    }

}