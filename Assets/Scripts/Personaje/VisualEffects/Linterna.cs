using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    
    public Light luzLinterna;
    public bool estado = false;


    void Start()
    {
        
       
        luzLinterna.enabled = false;
    }

    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.F))
        {
            estado = !estado;
            GestorDeAudio.instancia.ReproducirSonido("Radio Boton");

            if (estado)
            {
                luzLinterna.enabled = true;
            }
            else
            {
                luzLinterna.enabled = false;
            }
        }
    }

 
}
