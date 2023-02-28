using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light foco;
    public Light luzLinterna;
    public bool estado = false;


    void Start()
    {
        
       
        luzLinterna.enabled = false;

        foco.enabled = false;
    }

    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.F))
        {
            estado = !estado;
            GestorDeAudio.instancia.ReproducirSonido("Radio Boton");

            if (estado)
            {
                foco.enabled = true;
                luzLinterna.enabled = true;
            }
            else
            {
                foco.enabled = false;
                luzLinterna.enabled = false;
            }
        }
    }

 
}
