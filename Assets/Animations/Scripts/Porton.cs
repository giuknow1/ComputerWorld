using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porton : MonoBehaviour
{
    public Animator porton;
    public bool estado = true;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && (estado))
        {
            porton.Play("Start");
            GestorDeAudio.instancia.ReproducirSonido("Ambiance");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            estado = false;
        }
    }
}
