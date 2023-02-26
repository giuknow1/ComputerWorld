using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Aud1 : Audio
{
    public  bool rep = true;
    public  bool control = false;

    public override void Audio1()
    {
       

        if ((rep) && (control == false))
        {

            control = true;
            GestorDeAudio.instancia.ReproducirSonido("Radio Boton");

            GestorDeAudio.instancia.ReproducirSonido("Audio1");

            StartCoroutine(audio1());

        }

    }

    IEnumerator audio1()
    {
        yield return new WaitForSeconds(12f);
        control = false;
    }


}