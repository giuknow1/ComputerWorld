using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porton : MonoBehaviour
{
    public Animator porton;
    public static bool estado2 = true;
    public bool estado = true;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && (estado))
        {
            porton.Play("Start");
            GestorDeAudio.instancia.ReproducirSonido("Ambiance");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            estado = false;
            StartCoroutine(Opening());
            StartCoroutine(Closing());
        }
    }

    IEnumerator Opening()
    {
        yield return new WaitForSeconds(3f);
        GestorDeAudio.instancia.ReproducirSonido("Opening");
    }

    IEnumerator Closing()
    {
        yield return new WaitForSeconds(14f);
        GestorDeAudio.instancia.ReproducirSonido("Gate");
        porton.Play("Closing1");
        estado2 = false;
    }

}
