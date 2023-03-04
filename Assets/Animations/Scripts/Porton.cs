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
            porton.Play("AbrirPorton");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            estado = false;
        }
    }
}
